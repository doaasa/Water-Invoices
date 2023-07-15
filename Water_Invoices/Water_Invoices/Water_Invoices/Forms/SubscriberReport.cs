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
    public partial class SubscriberReport : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-SFDKHS6\SQLEXPRESS; Database=Water_Invoices;Integrated Security=true;");

        public SubscriberReport()
        {
            
            InitializeComponent();
            loadSubsrciber();
        }
        public void loadSubsrciber()
        {          
           try
            {
                int n = 1;
                con.Open();
                string query = "Select t1.NWC_Subscriber_File_Id,t1.NWC_Subscriber_File_Name," +
                    "t1.NWC_Subscriber_File_City,t1.NWC_Subscriber_File_Area,t1.NWC_Subscriber_File_Mobile , " +
                    "COUNT(t2.NWC_Subscription_File_Subscriber_Code) AS count " +
                    "from NWC_Subscriber_File t1 " +
                    "LEFT JOIN NWC_Subscription_File t2 ON t1.NWC_Subscriber_File_Id = t2.NWC_Subscription_File_Subscriber_Code GROUP BY t1.NWC_Subscriber_File_Id,t1.NWC_Subscriber_File_Name," +
                    "t1.NWC_Subscriber_File_City,t1.NWC_Subscriber_File_Area,t1.NWC_Subscriber_File_Mobile";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader data;
                data = cmd.ExecuteReader();
                while (data.Read())
                {
                    SubtionReportDG.Rows.Add(n, data[0].ToString(), data[1].ToString(), data[2].ToString(), data[3].ToString(), data[4].ToString(),data[5].ToString());
                    n++;
                }
                data.Close();
               

                SubtionReportDG.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                SubtionReportDG.GridColor = Color.Black;

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
