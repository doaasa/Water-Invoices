
namespace Water_Invoices.Forms
{
    partial class InvoicesReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.InvoiceReportDG = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Cancelbtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUsage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentUsage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceReportDG)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.InvoiceReportDG);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 455);
            this.panel2.TabIndex = 5;
            // 
            // InvoiceReportDG
            // 
            this.InvoiceReportDG.AllowUserToAddRows = false;
            this.InvoiceReportDG.AllowUserToDeleteRows = false;
            this.InvoiceReportDG.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arabic Typesetting", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.InvoiceReportDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.InvoiceReportDG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InvoiceReportDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arabic Typesetting", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InvoiceReportDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.InvoiceReportDG.ColumnHeadersHeight = 38;
            this.InvoiceReportDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.InvoiceNum,
            this.SubNo,
            this.ID,
            this.NameC,
            this.Date,
            this.LastUsage,
            this.CurrentUsage,
            this.Amount,
            this.Total,
            this.Bill});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arabic Typesetting", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InvoiceReportDG.DefaultCellStyle = dataGridViewCellStyle4;
            this.InvoiceReportDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InvoiceReportDG.GridColor = System.Drawing.Color.Black;
            this.InvoiceReportDG.Location = new System.Drawing.Point(0, 0);
            this.InvoiceReportDG.Name = "InvoiceReportDG";
            this.InvoiceReportDG.ReadOnly = true;
            this.InvoiceReportDG.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InvoiceReportDG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.InvoiceReportDG.RowHeadersVisible = false;
            this.InvoiceReportDG.RowHeadersWidth = 51;
            this.InvoiceReportDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.InvoiceReportDG.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.InvoiceReportDG.RowTemplate.Height = 26;
            this.InvoiceReportDG.Size = new System.Drawing.Size(1002, 455);
            this.InvoiceReportDG.TabIndex = 11;
            this.InvoiceReportDG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.InvoiceReportDG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.InvoiceReportDG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.InvoiceReportDG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.InvoiceReportDG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.InvoiceReportDG.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.InvoiceReportDG.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.InvoiceReportDG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.InvoiceReportDG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.InvoiceReportDG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.InvoiceReportDG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.InvoiceReportDG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.InvoiceReportDG.ThemeStyle.HeaderStyle.Height = 38;
            this.InvoiceReportDG.ThemeStyle.ReadOnly = true;
            this.InvoiceReportDG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.InvoiceReportDG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.InvoiceReportDG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.InvoiceReportDG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.InvoiceReportDG.ThemeStyle.RowsStyle.Height = 26;
            this.InvoiceReportDG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.InvoiceReportDG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancelbtn.BorderRadius = 20;
            this.Cancelbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Cancelbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Cancelbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Cancelbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Cancelbtn.FillColor = System.Drawing.Color.Crimson;
            this.Cancelbtn.Font = new System.Drawing.Font("Arabic Typesetting", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Cancelbtn.ForeColor = System.Drawing.Color.White;
            this.Cancelbtn.Location = new System.Drawing.Point(864, 14);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(126, 49);
            this.Cancelbtn.TabIndex = 89;
            this.Cancelbtn.Text = "انهاء";
            this.Cancelbtn.TextOffset = new System.Drawing.Point(0, -2);
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Cancelbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 455);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1002, 75);
            this.panel1.TabIndex = 4;
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.No.DefaultCellStyle = dataGridViewCellStyle3;
            this.No.HeaderText = "م";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 54;
            // 
            // InvoiceNum
            // 
            this.InvoiceNum.HeaderText = "رقم الفاتورة";
            this.InvoiceNum.MinimumWidth = 6;
            this.InvoiceNum.Name = "InvoiceNum";
            this.InvoiceNum.ReadOnly = true;
            // 
            // SubNo
            // 
            this.SubNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SubNo.HeaderText = "رقم الأشتراك";
            this.SubNo.MinimumWidth = 6;
            this.SubNo.Name = "SubNo";
            this.SubNo.ReadOnly = true;
            this.SubNo.Width = 133;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "رقم المشترك";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // NameC
            // 
            this.NameC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameC.HeaderText = "الأسم";
            this.NameC.MinimumWidth = 6;
            this.NameC.Name = "NameC";
            this.NameC.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.HeaderText = "تاريخ الفاتورة";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // LastUsage
            // 
            this.LastUsage.HeaderText = "الأستهلاك السابق";
            this.LastUsage.MinimumWidth = 6;
            this.LastUsage.Name = "LastUsage";
            this.LastUsage.ReadOnly = true;
            // 
            // CurrentUsage
            // 
            this.CurrentUsage.HeaderText = "الأستهلاك الحالي";
            this.CurrentUsage.MinimumWidth = 6;
            this.CurrentUsage.Name = "CurrentUsage";
            this.CurrentUsage.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "كمية الأستهلاك";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "مجموع الفاتورة";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Bill
            // 
            this.Bill.HeaderText = "اجمالي الفاتورة";
            this.Bill.MinimumWidth = 6;
            this.Bill.Name = "Bill";
            this.Bill.ReadOnly = true;
            // 
            // InvoicesReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1002, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arabic Typesetting", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvoicesReport";
            this.Text = "InvoicesReport";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceReportDG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView InvoiceReportDG;
        public Guna.UI2.WinForms.Guna2Button Cancelbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUsage;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentUsage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bill;
    }
}