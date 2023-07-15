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
    public partial class SubscribtionUpdate : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-SFDKHS6\SQLEXPRESS; Database=Water_Invoices;Integrated Security=true;");
        bool check = false;
        public SubscribtionUpdate()
        {
            InitializeComponent();
        }
        public void clear()
        {
            TxtID.Clear();
            TxtName.Clear();
            TxtCity.Clear();
            TxtArea.Clear();
            TxtPhone.Clear();
            TxtNotes.Clear();
        }

        public void Checkfields()
        {
            if (TxtID.Text == "" || TxtName.Text == "" || TxtCity.Text == "" || TxtArea.Text == "" || TxtPhone.Text == "")
            {
                MessageBox.Show("يجب ملئ جميع البيانات", "تحديث بيانات مشترك", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            check = true;
        }
        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت واثق من انك تريد الانهاء دون حفظ التعديلات؟", "تحديث بيانات مشترك", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                clear();
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

        private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Prevent the character from being entered
            }
            // Check the length of the text in the textbox
            if (TxtPhone.Text.Length >= 20 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            string ID = TxtID.Text;
            string Name = TxtName.Text;
            string City = TxtCity.Text;
            string Area = TxtArea.Text;
            string Phone = TxtPhone.Text;
            string Notes = TxtNotes.Text;

            Checkfields();
            if (check)
            {

                try
                {
                    SqlCommand cmd2 = new SqlCommand("update NWC_Subscriber_File set NWC_Subscriber_File_Name ='" + Name + "',NWC_Subscriber_File_Reasons='" + Notes + "', NWC_Subscriber_File_City='" + City + "',NWC_Subscriber_File_Area='" + Area + "',NWC_Subscriber_File_Mobile='" + Phone + "' where NWC_Subscriber_File_Id ='" + ID + "'", con);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("تم التحديث بنجاح", "تحديث بيانات نوع العقار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }



                catch 
                {
                     MessageBox.Show("معذرة لقد حدث خطأ ما");
                    //MessageBox.Show(ex.Message);

                }
                finally
                {
                    con.Close();
                }

            }
        
        }

        private void TxtID_Leave(object sender, EventArgs e)
        {
            string ID = TxtID.Text;
            if (ID != "")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select  NWC_Subscriber_File_Name,NWC_Subscriber_File_City,NWC_Subscriber_File_Area,NWC_Subscriber_File_Mobile,NWC_Subscriber_File_Reasons from NWC_Subscriber_File where NWC_Subscriber_File_Id ='" + ID + "'", con);
                SqlDataReader data;
                data = cmd.ExecuteReader();
                if (data.Read())
                {
                    TxtName.Text = data["NWC_Subscriber_File_Name"].ToString();
                    TxtCity.Text = data["NWC_Subscriber_File_City"].ToString();
                    TxtArea.Text = data["NWC_Subscriber_File_Area"].ToString();
                    TxtPhone.Text = data["NWC_Subscriber_File_Mobile"].ToString();
                    TxtNotes.Text = data["NWC_Subscriber_File_Reasons"].ToString();


                    data.Close();

                }
                else
                {
                    MessageBox.Show("يرجى التأكد من رقم الهوية");
                }
            }
            else
            {
                MessageBox.Show("يرجى ادخال رقم الهوية للتحديث");

            }

        }
    }
}