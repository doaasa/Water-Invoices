
namespace Water_Invoices
{
    partial class SubscribtionReport
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
            this.SubtionReportDG = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Cancelbtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Waste = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastRead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubtionReportDG)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SubtionReportDG);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 455);
            this.panel2.TabIndex = 3;
            // 
            // SubtionReportDG
            // 
            this.SubtionReportDG.AllowUserToAddRows = false;
            this.SubtionReportDG.AllowUserToDeleteRows = false;
            this.SubtionReportDG.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arabic Typesetting", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SubtionReportDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SubtionReportDG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SubtionReportDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arabic Typesetting", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubtionReportDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SubtionReportDG.ColumnHeadersHeight = 38;
            this.SubtionReportDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.SubNo,
            this.ID,
            this.NameC,
            this.Phone,
            this.Type,
            this.UnitNo,
            this.Waste,
            this.LastRead,
            this.Notes});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arabic Typesetting", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SubtionReportDG.DefaultCellStyle = dataGridViewCellStyle4;
            this.SubtionReportDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubtionReportDG.GridColor = System.Drawing.Color.Black;
            this.SubtionReportDG.Location = new System.Drawing.Point(0, 0);
            this.SubtionReportDG.Name = "SubtionReportDG";
            this.SubtionReportDG.ReadOnly = true;
            this.SubtionReportDG.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SubtionReportDG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.SubtionReportDG.RowHeadersVisible = false;
            this.SubtionReportDG.RowHeadersWidth = 51;
            this.SubtionReportDG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.SubtionReportDG.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.SubtionReportDG.RowTemplate.Height = 26;
            this.SubtionReportDG.Size = new System.Drawing.Size(1002, 455);
            this.SubtionReportDG.TabIndex = 11;
            this.SubtionReportDG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SubtionReportDG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SubtionReportDG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SubtionReportDG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SubtionReportDG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SubtionReportDG.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SubtionReportDG.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.SubtionReportDG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SubtionReportDG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.SubtionReportDG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.SubtionReportDG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SubtionReportDG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.SubtionReportDG.ThemeStyle.HeaderStyle.Height = 38;
            this.SubtionReportDG.ThemeStyle.ReadOnly = true;
            this.SubtionReportDG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SubtionReportDG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SubtionReportDG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.SubtionReportDG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SubtionReportDG.ThemeStyle.RowsStyle.Height = 26;
            this.SubtionReportDG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SubtionReportDG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.panel1.TabIndex = 2;
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
            // SubNo
            // 
            this.SubNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SubNo.HeaderText = "رقم الأشتراك";
            this.SubNo.MinimumWidth = 6;
            this.SubNo.Name = "SubNo";
            this.SubNo.ReadOnly = true;
            this.SubNo.Width = 132;
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
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Phone.HeaderText = "رقم الجوال";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "نوع العقار";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // UnitNo
            // 
            this.UnitNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UnitNo.HeaderText = "عدد الوحدات";
            this.UnitNo.MinimumWidth = 6;
            this.UnitNo.Name = "UnitNo";
            this.UnitNo.ReadOnly = true;
            this.UnitNo.Width = 143;
            // 
            // Waste
            // 
            this.Waste.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Waste.HeaderText = "هل يوجد صرف صحي";
            this.Waste.MinimumWidth = 6;
            this.Waste.Name = "Waste";
            this.Waste.ReadOnly = true;
            this.Waste.Width = 204;
            // 
            // LastRead
            // 
            this.LastRead.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LastRead.HeaderText = "اخر قراءة للعداد";
            this.LastRead.MinimumWidth = 6;
            this.LastRead.Name = "LastRead";
            this.LastRead.ReadOnly = true;
            this.LastRead.Width = 163;
            // 
            // Notes
            // 
            this.Notes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Notes.HeaderText = "ملاحظات";
            this.Notes.MinimumWidth = 6;
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            this.Notes.Width = 120;
            // 
            // SubscribtionReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1002, 530);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arabic Typesetting", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubscribtionReport";
            this.Text = "SubscribtionReport";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubtionReportDG)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView SubtionReportDG;
        public Guna.UI2.WinForms.Guna2Button Cancelbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Waste;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastRead;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
    }
}