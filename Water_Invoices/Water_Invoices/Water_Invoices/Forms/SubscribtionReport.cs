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
    public partial class SubscribtionReport : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-SFDKHS6\SQLEXPRESS; Database=Water_Invoices;Integrated Security=true;");

        public SubscribtionReport()
        {
            InitializeComponent();
            loadSubsrcibtion();
        }

        public void loadSubsrcibtion()
        {
            try
            {
                int n = 1;
                con.Open();
                string query = "SELECT t1.NWC_Subscription_File_No, t1.NWC_Subscription_File_Subscriber_Code," +
                    " t2.NWC_Subscriber_File_Name,t2.NWC_Subscriber_File_Mobile,t3.NWC_Rreal_Estate_Types_Name," +
                    "t1.NWC_Subscription_File_Unit_No," +
                    "CASE WHEN t1.NWC_Subscription_File_Is_There_Sanitation = 1 " +
                    "THEN 'نعم' ELSE 'لا' END AS 'NWC_Subscription_File_Is_There_Sanitation'," +
                    "t1.NWC_Subscription_File_Last_Reading_Meter,t1.NWC_Subscription_File_Reasons " +
                    "FROM NWC_Subscription_File t1 " +
                    "LEFT JOIN NWC_Subscriber_File t2 ON t1.NWC_Subscription_File_Subscriber_Code " +
                    "= t2.NWC_Subscriber_File_Id " +
                    "LEFT JOIN NWC_Rreal_Estate_Types t3 ON t1.NWC_Subscription_File_Rreal_Estate_Types_Code" +
                    " = t3.NWC_Rreal_Estate_Types_Code";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader data;
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    SubtionReportDG.Rows.Add(n, data[0].ToString(), data[1].ToString(), data[2].ToString(), data[3].ToString(), data[4].ToString(), data[5].ToString(), data[6].ToString(), data[7].ToString(), data[8].ToString());
                    n++;
                }
                data.Close();
                
                SubtionReportDG.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                SubtionReportDG.GridColor = Color.Black;
                SubtionReportDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                SubtionReportDG.Columns["Phone"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                SubtionReportDG.Columns["NameC"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MainForm.myButton.Visible = false;

        }

      
    }
}
