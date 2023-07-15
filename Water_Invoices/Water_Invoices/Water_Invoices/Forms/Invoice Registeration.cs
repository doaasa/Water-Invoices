using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Water_Invoices
{
 
    public partial class Invoice_Registeration : Form
    {

        static int numm;
        static Tuple<List<int>, int> SplitNumber(int num)
        {
            List<int> result = new List<int>();
            while (num > 0 && result.Count < 4)
            {
                if (num <= (15* numm))
                {
                    result.Add(num);
                    break;
                }
                else
                {
                    result.Add((15 * numm));
                    num -= (15 * numm);
                }
            }
            return Tuple.Create(result, num);
        }
 
        public decimal CalculateWaste(decimal water)
        {
            decimal PriceWaste = 0.0m;
            if (TxtWasteWater.Text == "نعم")
            {
                PriceWaste = water * .5m;
            }

            return PriceWaste;
        }
        public decimal CalculateWater()
        {
            int WaterUsage = int.Parse(TxtUsage.Text);
            Tuple<List<int>, int> splitResult = SplitNumber(WaterUsage);
            List<int> groups = splitResult.Item1;
            int remainingSum = 0;
            decimal priceWater = 0.0m;
            int SliceMax = (15 * int.Parse(TxtUnitNo.Text));
            if (WaterUsage != (4 * SliceMax))
            {
                remainingSum = splitResult.Item2;
            }
            if (WaterUsage <= 4 * SliceMax)
            {
                if (WaterUsage <= SliceMax)
                {
                    int first = groups[0];
                    priceWater = ((first * firstSlice));
                }
                else if (WaterUsage <= 2 * SliceMax)
                {
                    int first2 = groups[0];
                    int second2 = groups[1];
                    priceWater = ((first2 * firstSlice) + (second2 * secondSlice));
                }
                else if (WaterUsage <= 3 * SliceMax)
                {
                    int first3 = groups[0];
                    int second3 = groups[1];
                    int third3 = groups[2];

                    priceWater = ((first3 * firstSlice) + (second3 * secondSlice) + (third3 * thirdSlice));
                }
                else if (WaterUsage <= 4 * SliceMax)
                {
                    int first4 = groups[0];
                    int second4 = groups[1];
                    int third4 = groups[2];
                    int fourth4 = groups[3];
                    priceWater = ((first4 * firstSlice) + (second4 * secondSlice) + (third4 * thirdSlice) + (fourth4 * forthSlice));
                }

            }
            else if (WaterUsage > 4 * SliceMax)
            {
                int first5 = groups[0];
                int second5 = groups[1];
                int third5 = groups[2];
                int fourth5 = groups[3];
                int fifth = remainingSum;
                priceWater = ((first5 * firstSlice) + (second5 * secondSlice) + (third5 * thirdSlice) + (fourth5 * forthSlice) + (fifth * fifthSlice));
            }
            return priceWater;
        }
        public void UpdateTaxValue()
        {
            decimal TaxValue = 0.0m;
            TaxValue = ((decimal.Parse(TxtSericePercentage.Text) / 100) * decimal.Parse(txtWaterUsagePrice.Text));
            if (TxtInoviceNum.Text != "")
            {
                con.Open();
                SqlCommand cmd2 = new SqlCommand("update NWC_Invoices set NWC_Invoices_Tax_Value='" + TaxValue + "' where NWC_Invoices_No = '" + TxtInoviceNum.Text + "'", con);

                cmd2.ExecuteNonQuery();
                con.Close();
            }
        }
        public void CalculateTax()
        {
            decimal TaxValue = 0.0m;
            decimal priceWater = CalculateWater();
            decimal PriceWaste = CalculateWaste(priceWater);
            decimal TotalPrice = 0.0m;
            decimal InvoicePrice = 0.0m;
            string value = TxtSericePrice.Text;
            decimal servicePrice = Convert.ToDecimal(value);

            txtWaterUsagePrice.Text = priceWater.ToString();
            txtWaterWastePrice.Text = PriceWaste.ToString();
            TotalPrice = (servicePrice + priceWater + PriceWaste);
            TxtInvoicePrice.Text = TotalPrice.ToString();
            TaxValue = (decimal.Parse(TxtSericePercentage.Text) / 100) * TotalPrice;
            InvoicePrice = (TaxValue + TotalPrice);
            TxtInvoicePriceTotal.Text = InvoicePrice.ToString();
        }


        SqlConnection con = new SqlConnection(@"Server=DESKTOP-SFDKHS6\SQLEXPRESS; Database=Water_Invoices;Integrated Security=true;");
        static decimal firstSlice = 0.0m;
        static decimal secondSlice = 0.0m;
        static decimal thirdSlice = 0.0m;
        static decimal forthSlice = 0.0m;
        static decimal fifthSlice = 0.0m;
        bool checkF = false;
        public Invoice_Registeration()
        {
            InitializeComponent();
            while (true)
            {
                DateTime now = DateTime.Now;
                int year = now.Year;
                int month = now.Month;
                Random random = new Random();

                int randomNumber = random.Next(1, 100);
                string subNum = $"{year}-{month:D2}-{randomNumber:D2}";
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select  NWC_Invoices_Year from NWC_Invoices where NWC_Invoices_No ='" + subNum + "'", con);
                    SqlDataReader data;
                    data = cmd.ExecuteReader();
                    if (data.Read())
                    {
                        continue;
                    }

                    else
                    {
                        TxtInoviceNum.Text = subNum;
                        break;
                    }

                }

                catch
                {
                    MessageBox.Show("معذرة لقد حدث خطأ ما");

                }
                finally
                {
                    con.Close();
                }

            }
            con.Open();
            SqlCommand cmdd = new SqlCommand("select  NWC_Default_Slice_Values_Water_Price from NWC_Default_Slice_Values", con);
            SqlDataReader reader = cmdd.ExecuteReader();
            int counter = 0;
            if (reader.HasRows)
            {
                while (reader.Read() && counter < 5)
                {
                    if (counter == 0) { firstSlice = reader.GetDecimal(0); }
                    if (counter == 1) { secondSlice = reader.GetDecimal(0); }
                    if (counter == 2) { thirdSlice = reader.GetDecimal(0); }
                    if (counter == 3) { forthSlice = reader.GetDecimal(0); }
                    if (counter == 4) { fifthSlice = reader.GetDecimal(0); }
                    counter++;
                }
            }
            reader.Close();
            con.Close();
            
            
        }

        private void TxtInoviceDate_Validating(object sender, CancelEventArgs e)
        {
            DateTime dateValue;
            if (!DateTime.TryParse(TxtInoviceDate.Text, out dateValue)) // Check if the entered text is a valid date
            {
                MessageBox.Show("من فضلك ادخل تاريخ صحيح");
                e.Cancel = true; // Cancel the validation to prevent the focus from moving to another control
                TxtInoviceDate.SelectAll(); // Select all the text in the text box for easy correction
            }

        }

        private void TxtInvoiceDateFROM_Validating(object sender, CancelEventArgs e)
        {
            DateTime dateValue;
            if (!DateTime.TryParse(TxtInvoiceDateFROM.Text, out dateValue))
            {
                MessageBox.Show("من فضلك ادخل تاريخ صحيح");
                e.Cancel = true;
                TxtInvoiceDateFROM.SelectAll();
            }

        }

        private void TxtSubtionNum_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (TxtSubtionNum.Text.Length >= 10 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void TxtSubtionNum_Leave(object sender, EventArgs e)
        {
            if (TxtSubtionNum.Text != "")
            {
                string SubscribtionNumber = TxtSubtionNum.Text;
                con.Open();
                SqlCommand cmd = new SqlCommand("select NWC_Subscription_File_Subscriber_Code,NWC_Subscription_File_Last_Reading_Meter,NWC_Subscription_File_Is_There_Sanitation,NWC_Subscription_File_Unit_No from NWC_Subscription_File where NWC_Subscription_File_No='" + SubscribtionNumber + "'", con);
                SqlDataReader data;
                data = cmd.ExecuteReader();
                if (data.Read())
                {
                    string ID = data.GetString(0);
                    string LastReading = (data.GetDecimal(1)).ToString();
                    string Waste = (data.GetBoolean(2)).ToString();
                    string Unit = (data.GetDecimal(3)).ToString();
                    data.Close();

                    SqlCommand cmd2 = new SqlCommand("select NWC_Subscriber_File_Name from NWC_Subscriber_File where NWC_Subscriber_File_Id='" + ID + "'", con);
                    SqlDataReader data2;
                    data2 = cmd2.ExecuteReader();
                    if (data2.Read())
                    {
                        string Name = data2.GetString(0);
                        TxtSubID.Text = ID;
                        TxtSubName.Text = Name;
                        TxtLastRead.Text = LastReading;
                        TxtUnitNo.Text = Unit;
                        if (Waste == "1")
                        {
                            TxtWasteWater.Text = "نعم";
                        }
                        else
                        {
                            TxtWasteWater.Text = "لا";

                        }

                    }

                }
                else
                {
                    MessageBox.Show("برجاء ادخال رقم اشتراك صحيح او قم بتسجيل اشتراك اولًا.");

                }
                con.Close();

            }
        }

        private void TxtNowRead_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)'.') // Check if the input character is not a digit or backspace
            {
                e.Handled = true; // Block the input
            }
            else if (TxtNowRead.Text.Length >= 10 && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)'.') // Check if the input length is already 2 and the input is not backspace
            {
                e.Handled = true; // Block the input
            }
        }

        private void TxtNowRead_Leave(object sender, EventArgs e)
        {
            if (TxtNowRead.Text != "")
            {
                if (TxtLastRead.Text != "")
                {
                    int Result = (int.Parse(TxtNowRead.Text) - int.Parse(TxtLastRead.Text));
                    TxtUsage.Text = Result.ToString();
                }

            }
        }

        private void TxtInvoiceDateFROM_TextChanged(object sender, EventArgs e)
        {
            if (TxtInvoiceDateFROM.Text != "")
            {
                DateTime now = DateTime.Now;
                TxtInvoiceDateTO.Text = now.ToString("yyyy-MM-dd");
            }
        }

        private void TxtSericePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)'.') // Check if the input character is not a digit or backspace
            {
                e.Handled = true; // Block the input
            }
            else if (TxtSericePrice.Text.Length >= 10 && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)'.') // Check if the input length is already 2 and the input is not backspace
            {
                e.Handled = true; // Block the input
            }
        }

        private void TxtSericePercentage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)'.') // Check if the input character is not a digit or backspace
            {
                e.Handled = true; // Block the input
            }
            else if (TxtSericePercentage.Text.Length >= 10 && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)'.') // Check if the input length is already 2 and the input is not backspace
            {
                e.Handled = true; // Block the input
            }
        }




        private void savebtn_Click(object sender, EventArgs e)
        {
            string Invoices_No = TxtInoviceNum.Text;
            string Invoices_Datee = TxtInoviceDate.Text;
            DateTime date = DateTime.Parse(Invoices_Datee);
            string Year = date.ToString("yy");
            string Invoices_Rreal_Estate_Types = "";  //get from sql
            con.Open();
            string Invoices_Subscription_No = TxtSubtionNum.Text;
            string Invoices_Subscriber_No = TxtSubID.Text;
            SqlCommand cmd2 = new SqlCommand("select NWC_Subscription_File_Rreal_Estate_Types_Code from NWC_Subscription_File where NWC_Subscription_File_Subscriber_Code='" + Invoices_Subscriber_No + "'", con);
            SqlDataReader data2;
            data2 = cmd2.ExecuteReader();
            if (data2.Read())
            {
                Invoices_Rreal_Estate_Types = data2.GetString(0);

            }
            data2.Close();
            con.Close();
            DateTime Invoices_Date = DateTime.Parse(TxtInoviceDate.Text);
            DateTime from = DateTime.Parse(TxtInvoiceDateFROM.Text);
            DateTime to = DateTime.Parse(TxtInvoiceDateTO.Text);
            int Previous_Consumption_Amount = int.Parse(TxtLastRead.Text);
            int Current_Consumption_Amount = int.Parse(TxtNowRead.Text);
            int Invoices_Amount_Consumption = int.Parse(TxtUsage.Text);
            decimal Invoices_Service_Fee = decimal.Parse(TxtSericePrice.Text);
            decimal Invoices_Tax_Rate = decimal.Parse(TxtSericePercentage.Text);
            int Waste = 0;
            if (TxtWasteWater.Text == "نعم")
            {
                Waste = 1;
            }
            else
            {
                Waste = 0;
            }
            decimal Invoices_Consumption_Value = decimal.Parse(txtWaterUsagePrice.Text);
            decimal Invoices_Wastewater_Consumption_Value = decimal.Parse(txtWaterWastePrice.Text);
            decimal Invoices_Total_Invoice = decimal.Parse(TxtInvoicePrice.Text);
            decimal Invoices_Total_Bill = decimal.Parse(TxtInvoicePriceTotal.Text);
            Checkfields();
            if (checkF)
            {
               
                    con.Open();

                    SqlCommand cmd = new SqlCommand("insert into NWC_Invoices(NWC_Invoices_No, NWC_Invoices_Year, NWC_Invoices_Rreal_Estate_Types, NWC_Invoices_Subscription_No," +
                        "NWC_Invoices_Subscriber_No,NWC_Invoices_Date,NWC_Invoices_From,NWC_Invoices_To,NWC_Invoices_Previous_Consumption_Amount, " +
                        "NWC_Invoices_Current_Consumption_Amount, NWC_Invoices_Amount_Consumption, NWC_Invoices_Service_Fee, NWC_Invoices_Tax_Rate," +
                        " NWC_Invoices_Is_There_Sanitation, " +
                        "NWC_Invoices_Consumption_Value, NWC_Invoices_Wastewater_Consumption_Value, NWC_Invoices_Total_Invoice, NWC_Invoices_Total_Bill) " +
                        "values(@NWC_Invoices_No, @NWC_Invoices_Year,@NWC_Invoices_Rreal_Estate_Types, @NWC_Invoices_Subscription_No,@NWC_Invoices_Subscriber_No" +
                        ",@NWC_Invoices_Date,@NWC_Invoices_From,@NWC_Invoices_To,@NWC_Invoices_Previous_Consumption_Amount, @NWC_Invoices_Current_Consumption_Amount, " +
                        "@NWC_Invoices_Amount_Consumption, @NWC_Invoices_Service_Fee, @NWC_Invoices_Tax_Rate, @NWC_Invoices_Is_There_Sanitation, @NWC_Invoices_Consumption_Value, " +
                        "@NWC_Invoices_Wastewater_Consumption_Value, @NWC_Invoices_Total_Invoice,@NWC_Invoices_Total_Bill)", con);

                    cmd.Parameters.AddWithValue("@NWC_Invoices_No", Invoices_No);
                    cmd.Parameters.AddWithValue("@NWC_Invoices_Year", Year);
                    cmd.Parameters.AddWithValue("@NWC_Invoices_Rreal_Estate_Types", Invoices_Rreal_Estate_Types);
                    cmd.Parameters.AddWithValue("@NWC_Invoices_Subscription_No", Invoices_Subscription_No);
                    cmd.Parameters.AddWithValue("@NWC_Invoices_Subscriber_No", Invoices_Subscriber_No);
                    cmd.Parameters.AddWithValue("@NWC_Invoices_Date", Invoices_Date);
                    cmd.Parameters.AddWithValue("@NWC_Invoices_From", from);
                    cmd.Parameters.AddWithValue("@NWC_Invoices_To", to);
                    cmd.Parameters.AddWithValue("@NWC_Invoices_Previous_Consumption_Amount", Previous_Consumption_Amount);
                    cmd.Parameters.AddWithValue("@NWC_Invoices_Current_Consumption_Amount", Current_Consumption_Amount);
                    cmd.Parameters.AddWithValue("@NWC_Invoices_Amount_Consumption", Invoices_Amount_Consumption);
                    cmd.Parameters.AddWithValue("@NWC_Invoices_Service_Fee", Invoices_Service_Fee);
                    cmd.Parameters.AddWithValue("@NWC_Invoices_Tax_Rate", Invoices_Tax_Rate);
                    cmd.Parameters.AddWithValue("@NWC_Invoices_Is_There_Sanitation", Waste);
                    cmd.Parameters.AddWithValue("@NWC_Invoices_Consumption_Value", Invoices_Consumption_Value);
                    cmd.Parameters.AddWithValue("@NWC_Invoices_Wastewater_Consumption_Value", Invoices_Wastewater_Consumption_Value);
                    cmd.Parameters.AddWithValue("@NWC_Invoices_Total_Invoice", Invoices_Total_Invoice);
                    cmd.Parameters.AddWithValue("@NWC_Invoices_Total_Bill", Invoices_Total_Bill);

                if (cmd.ExecuteNonQuery() > 0)
                    {
                        SqlCommand cmdd = new SqlCommand("update NWC_Subscription_File set NWC_Subscription_File_Last_Reading_Meter='"+ Current_Consumption_Amount + "'where NWC_Subscription_File_No='" + Invoices_Subscription_No + "'", con);

                        cmdd.ExecuteNonQuery();
                        con.Close();

                        UpdateTaxValue();
                        MessageBox.Show("تم الحفظ بنجاح", "تسجيل الفاتورة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();

                }

                con.Close();
                

            }
        }
        public void clear()
        {
            txtWaterUsagePrice.Clear();
            txtWaterWastePrice.Clear();
            TxtInoviceDate.Clear();
            TxtInoviceNum.Clear();
            TxtInvoiceDateFROM.Clear();
            TxtInvoiceDateTO.Clear();
            TxtInvoicePrice.Clear();
            TxtInvoicePriceTotal.Clear();
            TxtSericePrice.Clear();
            TxtLastRead.Clear();
            TxtNowRead.Clear();
            TxtSericePercentage.Clear();
            TxtSubID.Clear();
            TxtSubName.Clear();
            TxtUnitNo.Clear();
            TxtUsage.Clear();
            TxtWasteWater.Clear();
            TxtSubtionNum.Clear();

        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت واثق من انك تريد الانهاء دون حفظ التعديلات؟", "تسجيل فاتورة", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TxtInvoiceDateFROM.TextChanged -= TxtInvoiceDateFROM_TextChanged;

                clear();
            }
        }
        public void Checkfields()
        {
            if (TxtInoviceNum.Text == "" || TxtInoviceDate.Text == "" || TxtSubtionNum.Text == "" ||
                TxtSubID.Text == "" || TxtInoviceDate.Text == "" || TxtInvoiceDateFROM.Text == "" ||
                TxtInvoiceDateTO.Text == "" || TxtLastRead.Text == "" || TxtNowRead.Text == "" ||
                TxtUsage.Text == "" || TxtSericePrice.Text == "" || TxtSericePercentage.Text == "" ||
                txtWaterUsagePrice.Text == "" || txtWaterWastePrice.Text == "" || TxtInvoicePrice.Text == ""
                || TxtInvoicePriceTotal.Text == "")
            {
                MessageBox.Show("برجاء ادخال جميع البيانات المطلوبة", "تسجيل فاتورة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                checkF = true;
            }
        }

    


        private void TxtSericePercentage_TextChanged(object sender, EventArgs e)
        {
            if (TxtSericePercentage.Text!=""){
                CalculateTax();

            }
        }

        private void TxtUnitNo_TextChanged(object sender, EventArgs e)
        {
            if (TxtUnitNo.Text != "")
            {
                numm = int.Parse(TxtUnitNo.Text);
            }
        }
    }
}
