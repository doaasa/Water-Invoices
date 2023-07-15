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
    public partial class TypeUpdate : Form
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-SFDKHS6\SQLEXPRESS; Database=Water_Invoices;Integrated Security=true;");
        bool check = false;

        public TypeUpdate()
        {
            InitializeComponent();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت واثق من انك تريد الانهاء دون حفظ التعديلات؟", "تحديث بيانات نوع العقار", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                clear();
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            string num =TxtTypeNum.Text;
            string details = TxtTypeDetails.Text;
            string notes = TxtNotes.Text;
            Checkfields();
            if (check)
            {
                try
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("select  NWC_Rreal_Estate_Types_Name from NWC_Rreal_Estate_Types where NWC_Rreal_Estate_Types_Code ='" + num + "'", con);
                    SqlDataReader data;
                    data = cmd.ExecuteReader();
                    if (data.Read())
                    {
                        data.Close();
                        SqlCommand cmd2 = new SqlCommand("update NWC_Rreal_Estate_Types set NWC_Rreal_Estate_Types_Name ='" + details + "',NWC_Rreal_Estate_Types_Reasons='"+notes+"' where NWC_Rreal_Estate_Types_Code ='" + num + "'", con);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("تم التحديث بنجاح", "تحديث بيانات نوع العقار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clear();
                    }

                    else
                    {
                        MessageBox.Show("يرجى التأكد من رمز العقار");
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
        public void clear()
        {
            TxtTypeDetails.Clear();
            TxtTypeNum.Clear();
        }

        public void Checkfields()
        {
            if (TxtTypeNum.Text == "" || TxtTypeDetails.Text == "")
            {
                MessageBox.Show("يجب ملئ جميع البيانات", "تحديث بيانات نوع العقار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            check = true;
        }

        private void TxtTypeDetails_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Prevent the character from being entered
            }

            // Check the length of the text in the textbox
            if (TxtTypeDetails.Text.Length >= 15 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }
    }
}
