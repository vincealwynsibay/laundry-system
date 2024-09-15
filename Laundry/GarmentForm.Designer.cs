namespace Laundry
{
    partial class GarmentForm
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
            this.txtGarmentType = new ReaLTaiizor.Controls.HopeTextBox();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.metroPanel1 = new ReaLTaiizor.Controls.MetroPanel();
            this.btnAddGarmentType = new ReaLTaiizor.Controls.HopeButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnServiceTypeLink = new ReaLTaiizor.Controls.RoyalButton();
            this.btnGarmentTypeLink = new ReaLTaiizor.Controls.RoyalButton();
            this.btnLaundryLink = new ReaLTaiizor.Controls.RoyalButton();
            this.btnCustomerLink = new ReaLTaiizor.Controls.RoyalButton();
            this.btnDashboardLink = new ReaLTaiizor.Controls.RoyalButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgridCustomers = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGarmentType
            // 
            this.txtGarmentType.BackColor = System.Drawing.Color.White;
            this.txtGarmentType.BaseColor = System.Drawing.Color.Transparent;
            this.txtGarmentType.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtGarmentType.BorderColorB = System.Drawing.Color.LightGray;
            this.txtGarmentType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGarmentType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtGarmentType.Hint = "";
            this.txtGarmentType.Location = new System.Drawing.Point(24, 51);
            this.txtGarmentType.MaxLength = 32767;
            this.txtGarmentType.Multiline = false;
            this.txtGarmentType.Name = "txtGarmentType";
            this.txtGarmentType.PasswordChar = '\0';
            this.txtGarmentType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGarmentType.SelectedText = "";
            this.txtGarmentType.SelectionLength = 0;
            this.txtGarmentType.SelectionStart = 0;
            this.txtGarmentType.Size = new System.Drawing.Size(319, 34);
            this.txtGarmentType.TabIndex = 21;
            this.txtGarmentType.TabStop = false;
            this.txtGarmentType.Text = "Enter Garment Type";
            this.txtGarmentType.UseSystemPasswordChar = false;
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dungeonLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel1.Location = new System.Drawing.Point(21, 35);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(80, 13);
            this.dungeonLabel1.TabIndex = 17;
            this.dungeonLabel1.Text = "Garment Type";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundColor = System.Drawing.Color.White;
            this.metroPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroPanel1.BorderThickness = 1;
            this.metroPanel1.Controls.Add(this.btnAddGarmentType);
            this.metroPanel1.Controls.Add(this.txtGarmentType);
            this.metroPanel1.Controls.Add(this.dungeonLabel1);
            this.metroPanel1.IsDerivedStyle = true;
            this.metroPanel1.Location = new System.Drawing.Point(235, 139);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(373, 235);
            this.metroPanel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroPanel1.StyleManager = null;
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.ThemeAuthor = "Taiizor";
            this.metroPanel1.ThemeName = "MetroLight";
            // 
            // btnAddGarmentType
            // 
            this.btnAddGarmentType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnAddGarmentType.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnAddGarmentType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGarmentType.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnAddGarmentType.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddGarmentType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGarmentType.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnAddGarmentType.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnAddGarmentType.Location = new System.Drawing.Point(24, 174);
            this.btnAddGarmentType.Name = "btnAddGarmentType";
            this.btnAddGarmentType.PrimaryColor = System.Drawing.Color.RoyalBlue;
            this.btnAddGarmentType.Size = new System.Drawing.Size(319, 40);
            this.btnAddGarmentType.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnAddGarmentType.TabIndex = 22;
            this.btnAddGarmentType.Text = "Add Garment Type";
            this.btnAddGarmentType.TextColor = System.Drawing.Color.White;
            this.btnAddGarmentType.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnAddGarmentType.Click += new System.EventHandler(this.hopeButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Garment Type";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btnServiceTypeLink);
            this.panel1.Controls.Add(this.btnGarmentTypeLink);
            this.panel1.Controls.Add(this.btnLaundryLink);
            this.panel1.Controls.Add(this.btnCustomerLink);
            this.panel1.Controls.Add(this.btnDashboardLink);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 510);
            this.panel1.TabIndex = 5;
            // 
            // btnServiceTypeLink
            // 
            this.btnServiceTypeLink.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnServiceTypeLink.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnServiceTypeLink.BorderThickness = 3;
            this.btnServiceTypeLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServiceTypeLink.DrawBorder = true;
            this.btnServiceTypeLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceTypeLink.ForeColor = System.Drawing.Color.White;
            this.btnServiceTypeLink.HotTrackColor = System.Drawing.Color.Transparent;
            this.btnServiceTypeLink.Image = null;
            this.btnServiceTypeLink.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
            this.btnServiceTypeLink.Location = new System.Drawing.Point(-53, 313);
            this.btnServiceTypeLink.Name = "btnServiceTypeLink";
            this.btnServiceTypeLink.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnServiceTypeLink.PressedForeColor = System.Drawing.Color.White;
            this.btnServiceTypeLink.Size = new System.Drawing.Size(241, 40);
            this.btnServiceTypeLink.TabIndex = 6;
            this.btnServiceTypeLink.Text = "Service Type";
            this.btnServiceTypeLink.Click += new System.EventHandler(this.btnServiceTypeLink_Click);
            // 
            // btnGarmentTypeLink
            // 
            this.btnGarmentTypeLink.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnGarmentTypeLink.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnGarmentTypeLink.BorderThickness = 3;
            this.btnGarmentTypeLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGarmentTypeLink.DrawBorder = true;
            this.btnGarmentTypeLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGarmentTypeLink.ForeColor = System.Drawing.Color.White;
            this.btnGarmentTypeLink.HotTrackColor = System.Drawing.Color.Transparent;
            this.btnGarmentTypeLink.Image = null;
            this.btnGarmentTypeLink.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
            this.btnGarmentTypeLink.Location = new System.Drawing.Point(-43, 273);
            this.btnGarmentTypeLink.Name = "btnGarmentTypeLink";
            this.btnGarmentTypeLink.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnGarmentTypeLink.PressedForeColor = System.Drawing.Color.White;
            this.btnGarmentTypeLink.Size = new System.Drawing.Size(230, 40);
            this.btnGarmentTypeLink.TabIndex = 6;
            this.btnGarmentTypeLink.Text = "Garment Type";
            this.btnGarmentTypeLink.Click += new System.EventHandler(this.btnGarmentTypeLink_Click);
            // 
            // btnLaundryLink
            // 
            this.btnLaundryLink.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLaundryLink.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnLaundryLink.BorderThickness = 3;
            this.btnLaundryLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLaundryLink.DrawBorder = true;
            this.btnLaundryLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaundryLink.ForeColor = System.Drawing.Color.White;
            this.btnLaundryLink.HotTrackColor = System.Drawing.Color.Transparent;
            this.btnLaundryLink.Image = null;
            this.btnLaundryLink.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
            this.btnLaundryLink.Location = new System.Drawing.Point(-52, 230);
            this.btnLaundryLink.Name = "btnLaundryLink";
            this.btnLaundryLink.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnLaundryLink.PressedForeColor = System.Drawing.Color.White;
            this.btnLaundryLink.Size = new System.Drawing.Size(235, 40);
            this.btnLaundryLink.TabIndex = 6;
            this.btnLaundryLink.Text = "Add Laundry";
            this.btnLaundryLink.Click += new System.EventHandler(this.btnLaundryLink_Click);
            // 
            // btnCustomerLink
            // 
            this.btnCustomerLink.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCustomerLink.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnCustomerLink.BorderThickness = 3;
            this.btnCustomerLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerLink.DrawBorder = true;
            this.btnCustomerLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerLink.ForeColor = System.Drawing.Color.White;
            this.btnCustomerLink.HotTrackColor = System.Drawing.Color.Transparent;
            this.btnCustomerLink.Image = null;
            this.btnCustomerLink.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
            this.btnCustomerLink.Location = new System.Drawing.Point(-70, 184);
            this.btnCustomerLink.Name = "btnCustomerLink";
            this.btnCustomerLink.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnCustomerLink.PressedForeColor = System.Drawing.Color.White;
            this.btnCustomerLink.Size = new System.Drawing.Size(258, 40);
            this.btnCustomerLink.TabIndex = 6;
            this.btnCustomerLink.Text = "Customers";
            this.btnCustomerLink.Click += new System.EventHandler(this.btnCustomerLink_Click);
            // 
            // btnDashboardLink
            // 
            this.btnDashboardLink.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDashboardLink.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnDashboardLink.BorderThickness = 3;
            this.btnDashboardLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboardLink.DrawBorder = true;
            this.btnDashboardLink.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboardLink.ForeColor = System.Drawing.Color.White;
            this.btnDashboardLink.HotTrackColor = System.Drawing.Color.Transparent;
            this.btnDashboardLink.Image = null;
            this.btnDashboardLink.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
            this.btnDashboardLink.Location = new System.Drawing.Point(-64, 138);
            this.btnDashboardLink.Name = "btnDashboardLink";
            this.btnDashboardLink.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnDashboardLink.PressedForeColor = System.Drawing.Color.White;
            this.btnDashboardLink.Size = new System.Drawing.Size(249, 40);
            this.btnDashboardLink.TabIndex = 6;
            this.btnDashboardLink.Text = "Dashboard";
            this.btnDashboardLink.Click += new System.EventHandler(this.btnDashboardLink_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Laundry.Properties.Resources.laundry_transparent;
            this.pictureBox2.Location = new System.Drawing.Point(13, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(169, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // dgridCustomers
            // 
            this.dgridCustomers.AllowUserToAddRows = false;
            this.dgridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Fullname,
            this.Email,
            this.Address,
            this.ContactNo,
            this.Gender});
            this.dgridCustomers.Location = new System.Drawing.Point(31, 116);
            this.dgridCustomers.Name = "dgridCustomers";
            this.dgridCustomers.Size = new System.Drawing.Size(647, 272);
            this.dgridCustomers.TabIndex = 10;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // Fullname
            // 
            this.Fullname.HeaderText = "Full Name";
            this.Fullname.Name = "Fullname";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // ContactNo
            // 
            this.ContactNo.HeaderText = "ContactNumber";
            this.ContactNo.Name = "ContactNo";
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            // 
            // GarmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 505);
            this.Controls.Add(this.dgridCustomers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.label1);
            this.Name = "GarmentForm";
            this.Text = "GarmentForm";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.HopeTextBox txtGarmentType;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.HopeButton btnAddGarmentType;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.RoyalButton btnServiceTypeLink;
        private ReaLTaiizor.Controls.RoyalButton btnGarmentTypeLink;
        private ReaLTaiizor.Controls.RoyalButton btnLaundryLink;
        private ReaLTaiizor.Controls.RoyalButton btnCustomerLink;
        private ReaLTaiizor.Controls.RoyalButton btnDashboardLink;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgridCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
    }
}