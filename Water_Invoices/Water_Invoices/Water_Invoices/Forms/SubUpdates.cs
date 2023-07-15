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
    public partial class SubUpdates : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-SFDKHS6\SQLEXPRESS; Database=Water_Invoices;Integrated Security=true;");
        bool checkF = false;

        public SubUpdates()
        {
            InitializeComponent();
          
            while (true)
            {
                DateTime now = DateTime.Now;
                int year = now.Year;
                string lastTwoDigits = (year % 100).ToString("00");
                int month = now.Month;
                Random random = new Random();

                int randomNumber = random.Next(1, 300);
                string subNum = $"{lastTwoDigits}-{month:D2}-{randomNumber:D3}";
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select  NWC_Subscription_File_Subscriber_Code from NWC_Subscription_File where NWC_Subscription_File_No ='" + subNum + "'", con);
                    SqlDataReader data;
                    data = cmd.ExecuteReader();
                    if (data.Read())
                    {
                        continue;
                    }

                    else
                    {
                        TxtSubNum.Text = subNum;
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

        }

        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) // Check if the input character is not a digit or backspace
            {
                e.Handled = true; // Block the input
            }
            else if (TxtID.Text.Length >= 10 && e.KeyChar != (char)Keys.Back) // Check if the input length is already 2 and the input is not backspace
            {
                e.Handled = true; // Block the input
            }
        }

        private void TxtID_Leave(object sender, EventArgs e)
        {
            if (TxtID.Text != "") {
                string ID = TxtID.Text;
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select NWC_Subscriber_File_Name,NWC_Subscriber_File_City,NWC_Subscriber_File_Area,NWC_Subscriber_File_Mobile from NWC_Subscriber_File where NWC_Subscriber_File_Id='" + ID+"'", con);
                    SqlDataReader data;
                    data = cmd.ExecuteReader();
                    if (data.Read())
                    {
                        TxtName.Text = data.GetString(0);
                        TxtCity.Text = data.GetString(1);
                        TxtPhone.Text = data.GetString(3);
                        TxtArea.Text = data.GetString(2);

                    }

                    else
                    {
                        MessageBox.Show("برجاء تسجيل بياناتك كمشترك اولًا");

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
        }

        private void TxtUnitNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) // Check if the input character is not a digit or backspace
            {
                e.Handled = true; // Block the input
            }
            else if (TxtUnitNum.Text.Length >= 2 && e.KeyChar != (char)Keys.Back) // Check if the input length is already 2 and the input is not backspace
            {
                e.Handled = true; // Block the input
            }
        }

        private void Yes_CheckedChanged(object sender, EventArgs e)
        {
            if (Yes.Checked)
            {
                No.Checked = false;
                No.Enabled = false;
            }
            else
            {
                No.Enabled = true;
            }
        }

        private void No_CheckedChanged(object sender, EventArgs e)
        {
            if (No.Checked)
            {
                Yes.Checked = false;
                Yes.Enabled = false;
            }
            else
            {
                Yes.Enabled = true;
            }
        }

        public void Checkfields()
        {
            if (TxtID.Text == "")
            {
                MessageBox.Show("يجب كتابة رقم الهوية لتحديث البيانات", "تحديث بيانات اشتراك", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                checkF = true;
            }
        }
        public void clear()
        {
            TxtID.Clear();
            TxtArea.Clear();
            TxtCity.Clear();
            TxtName.Clear();
            TxtPhone.Clear();
            TxtNotes.Clear();
            TxtSubNum.Clear();
            TxtUnitNum.Clear();
            Type.Text = "";
            Yes.Checked = false;
            No.Checked = false;
            

        }
        private void savebtn_Click(object sender, EventArgs e)
        {
            string SubNum = TxtSubNum.Text;
            string ID = TxtID.Text;
            string UnitNum = TxtUnitNum.Text;
            string type = Type.Text;
            string notes = TxtNotes.Text;
            string typeN = "1";
            if(type != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select NWC_Rreal_Estate_Types_Code from NWC_Rreal_Estate_Types where NWC_Rreal_Estate_Types_Name='" + type + "'", con);
                SqlDataReader data;
                data = cmd.ExecuteReader();
                if (data.Read())
                {
                    typeN = data.GetString(0);

                }
                else
                {
                    MessageBox.Show("برجاء اختيار نوع العقار للتسجيل");

                }
            }
            con.Close();
            int check = 0;
            if (Yes.Checked)
            {
                check = 1;
            }
            if (No.Checked)
            {
                check = 0;
            }
            Checkfields();
            if (checkF)
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("insert into NWC_Subscription_File(NWC_Subscription_File_No,NWC_Subscription_File_Subscriber_Code,NWC_Subscription_File_Rreal_Estate_Types_Code,NWC_Subscription_File_Unit_No,NWC_Subscription_File_Is_There_Sanitation,NWC_Subscription_File_Reasons)values(@NWC_Subscription_File_No,@NWC_Subscription_File_Subscriber_Code,@NWC_Subscription_File_Rreal_Estate_Types_Code,@NWC_Subscription_File_Unit_No,@NWC_Subscription_File_Is_There_Sanitation,@NWC_Subscription_File_Reasons)", con);
                    cmd.Parameters.AddWithValue("@NWC_Subscription_File_No", SubNum);
                    cmd.Parameters.AddWithValue("@NWC_Subscription_File_Subscriber_Code", ID);
                    cmd.Parameters.AddWithValue("@NWC_Subscription_File_Rreal_Estate_Types_Code", typeN);
                    cmd.Parameters.AddWithValue("@NWC_Subscription_File_Unit_No", UnitNum);
                    cmd.Parameters.AddWithValue("@NWC_Subscription_File_Is_There_Sanitation", check);
                    cmd.Parameters.AddWithValue("@NWC_Subscription_File_Reasons", notes);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("تم الحفظ بنجاح", "تحديث بيانات اشتراك", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت واثق من انك تريد الانهاء دون حفظ التعديلات؟", "تحديث بيانات اشتراك", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                clear();
            }
        }
    }
}
