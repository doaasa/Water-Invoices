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

namespace Water_Invoices.Forms
{
    public partial class SearchInvoice : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-SFDKHS6\SQLEXPRESS; Database=Water_Invoices;Integrated Security=true;");

        public SearchInvoice()
        {
            InitializeComponent();
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
            if (MessageBox.Show("هل انت واثق من انك تريد الانهاء واغلاق النتائج", "استفسار عن فاتورة", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                clear();
            }
        }

        private void TxtInoviceNum_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }


        public void loadData()
        {
            con.Open();
            string query = "SELECT t1.NWC_Invoices_Date,t1.NWC_Invoices_From,t1.NWC_Invoices_To,t1.NWC_Invoices_Subscription_No," +
                "t1.NWC_Invoices_Subscriber_No , t2.NWC_Subscriber_File_Name," +
                "t1.NWC_Invoices_Previous_Consumption_Amount,t1.NWC_Invoices_Current_Consumption_Amount," +
                "t1.NWC_Invoices_Amount_Consumption," +
                "CASE WHEN t1.NWC_Invoices_Is_There_Sanitation = 1 THEN 'نعم' ELSE 'لا' END AS 'NWC_Subscription_File_Is_There_Sanitation'" +
                ",t3.NWC_Subscription_File_Unit_No,t1.NWC_Invoices_Service_Fee," +
                "t1.NWC_Invoices_Tax_Rate,t1.NWC_Invoices_Consumption_Value," +
                "t1.NWC_Invoices_Wastewater_Consumption_Value,t1.NWC_Invoices_Total_Invoice," +
                "t1.NWC_Invoices_Total_Bill " +
                "FROM NWC_Invoices t1 " +
                "LEFT JOIN NWC_Subscriber_File t2 ON t1.NWC_Invoices_Subscriber_No = t2.NWC_Subscriber_File_Id" +
                " LEFT JOIN NWC_Subscription_File t3 ON t1.NWC_Invoices_Subscription_No = t3.NWC_Subscription_File_No" +
                " WHERE t1.NWC_Invoices_No = '"+TxtInoviceNum.Text+"'";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader data;
            data = cmd.ExecuteReader();
            while (data.Read())
            {
                TxtInoviceDate.Text = data[0].ToString();
                TxtInvoiceDateFROM.Text = data[1].ToString();
                TxtInvoiceDateTO.Text = data[2].ToString();
                TxtSubtionNum.Text = data[3].ToString();
                TxtSubID.Text = data[4].ToString();
                TxtSubName.Text = data[5].ToString();
                TxtLastRead.Text = data[6].ToString();
                TxtNowRead.Text = data[7].ToString();
                TxtUsage.Text = data[8].ToString();
                TxtWasteWater.Text = data[9].ToString();
                TxtUnitNo.Text = data[10].ToString();
                TxtSericePrice.Text = data[11].ToString();

                TxtSericePercentage.Text = data[12].ToString();
                txtWaterUsagePrice.Text = data[13].ToString();
                txtWaterWastePrice.Text = data[14].ToString();
                TxtInvoicePrice.Text = data[15].ToString();
                TxtInvoicePriceTotal.Text = data[16].ToString();
            }
            data.Close();
            con.Close();

        }
    }
}
