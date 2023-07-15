using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Water_Invoices.Forms;

namespace Water_Invoices
{
    public partial class MainForm : Form
    {
        public static Guna.UI2.WinForms.Guna2Button myButton;

        public MainForm()
        {
            InitializeComponent();
            myButton = this.backbtn;
            backbtn.Visible = false;
        }
        private Form activeform = null;
        public void openChildForm(Form child)
        {
            if (activeform != null)
                activeform.Close();
            
            activeform = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panelchildform.Controls.Add(child);
            panelchildform.Tag = child;
            child.BringToFront();
            child.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnUpdateType_Click(object sender, EventArgs e)
        {
            TypeUpdate typeUpdate = new TypeUpdate();

            openChildForm(typeUpdate);

            backbtn.Visible = true;

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Invoice_Registeration invoice_Registeration = new Invoice_Registeration();

            openChildForm(invoice_Registeration);
            backbtn.Visible = true;

        }

        private void btnUpdateSub_Click(object sender, EventArgs e)
        {
            SubscribtionUpdate subscribtionUpdate = new SubscribtionUpdate();

            openChildForm(subscribtionUpdate);
            backbtn.Visible = true;

        }

        private void btnUpdateSubtion_Click(object sender, EventArgs e)
        {
            SubUpdates subUpdates = new SubUpdates();
            openChildForm(subUpdates);
            backbtn.Visible = true;


        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            activeform.Close();
            backbtn.Visible = false;

        }

        private void btnSubReport_Click(object sender, EventArgs e)
        {
            SubscriberReport subscriberReport = new SubscriberReport();
            openChildForm(subscriberReport);
            backbtn.Visible = true;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SubscribtionReport subscribtionReport = new SubscribtionReport();
            openChildForm(subscribtionReport);
            backbtn.Visible = true;

        }

        private void btnInvoicesReport_Click(object sender, EventArgs e)
        {
            InvoicesReport invoicesReport = new InvoicesReport();
            openChildForm(invoicesReport);
            backbtn.Visible = true;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchInvoice searchInvoice = new SearchInvoice();
            openChildForm(searchInvoice);
            backbtn.Visible = true;

        }
    }
}
