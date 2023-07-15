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
    public partial class InvoicesReport : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-SFDKHS6\SQLEXPRESS; Database=Water_Invoices;Integrated Security=true;");
        public InvoicesReport()
        {
            InitializeComponent();
            loadData();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MainForm.myButton.Visible = false;
        }

        public void loadData()
        {
           
                int n = 1;
                con.Open();
            string query2 = "SELECT t1.NWC_Invoices_No,t1.NWC_Invoices_Subscription_No," +
                "t1.NWC_Invoices_Subscriber_No,t2.NWC_Subscriber_File_Name," +
                "CONVERT(varchar, t1.NWC_Invoices_Date, 3) AS formatted_date," +
                "t1.NWC_Invoices_Previous_Consumption_Amount," +
                "t1.NWC_Invoices_Current_Consumption_Amount," +
                " t1.NWC_Invoices_Amount_Consumption," +
                " t1.NWC_Invoices_Total_Invoice," +
                " t1.NWC_Invoices_Total_Bill" +
                " FROM NWC_Invoices t1" +
                " LEFT JOIN NWC_Subscriber_File t2 ON t1.NWC_Invoices_Subscriber_No = t2.NWC_Subscriber_File_Id";
              
                SqlCommand cmd = new SqlCommand(query2, con);
                SqlDataReader data;
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    InvoiceReportDG.Rows.Add(n, data[0].ToString(), data[1].ToString(), data[2].ToString(), data[3].ToString(), data[4].ToString(), data[5].ToString(), data[6].ToString(), data[7].ToString(), data[8].ToString(), data[9].ToString());
                    n++;
                }
                data.Close();

                InvoiceReportDG.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                InvoiceReportDG.GridColor = Color.Black;
            
                InvoiceReportDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                InvoiceReportDG.Columns["NameC"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            con.Close();
            
        }
    }
}
