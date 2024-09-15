namespace Laundry
{
    partial class CustomerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.metroPanel1 = new ReaLTaiizor.Controls.MetroPanel();
            this.btnAddCustomer = new ReaLTaiizor.Controls.HopeButton();
            this.picCustomer = new System.Windows.Forms.PictureBox();
            this.rdoGender2 = new ReaLTaiizor.Controls.HopeRadioButton();
            this.rdoGender1 = new ReaLTaiizor.Controls.HopeRadioButton();
            this.dateBirthdate = new ReaLTaiizor.Controls.PoisonDateTime();
            this.txtContactNumber = new ReaLTaiizor.Controls.HopeTextBox();
            this.dungeonLabel6 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLabel3 = new ReaLTaiizor.Controls.DungeonLabel();
            this.txtEmail = new ReaLTaiizor.Controls.HopeTextBox();
            this.dungeonLabel5 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLabel4 = new ReaLTaiizor.Controls.DungeonLabel();
            this.txtAddress = new ReaLTaiizor.Controls.HopeTextBox();
            this.dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            this.txtFullname = new ReaLTaiizor.Controls.HopeTextBox();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnServiceTypeLink = new ReaLTaiizor.Controls.RoyalButton();
            this.btnGarmentTypeLink = new ReaLTaiizor.Controls.RoyalButton();
            this.btnLaundryLink = new ReaLTaiizor.Controls.RoyalButton();
            this.btnCustomerLink = new ReaLTaiizor.Controls.RoyalButton();
            this.btnDashboardLink = new ReaLTaiizor.Controls.RoyalButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Info";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundColor = System.Drawing.Color.White;
            this.metroPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroPanel1.BorderThickness = 1;
            this.metroPanel1.Controls.Add(this.btnAddCustomer);
            this.metroPanel1.Controls.Add(this.picCustomer);
            this.metroPanel1.Controls.Add(this.rdoGender2);
            this.metroPanel1.Controls.Add(this.rdoGender1);
            this.metroPanel1.Controls.Add(this.dateBirthdate);
            this.metroPanel1.Controls.Add(this.txtContactNumber);
            this.metroPanel1.Controls.Add(this.dungeonLabel6);
            this.metroPanel1.Controls.Add(this.dungeonLabel3);
            this.metroPanel1.Controls.Add(this.txtEmail);
            this.metroPanel1.Controls.Add(this.dungeonLabel5);
            this.metroPanel1.Controls.Add(this.dungeonLabel4);
            this.metroPanel1.Controls.Add(this.txtAddress);
            this.metroPanel1.Controls.Add(this.dungeonLabel2);
            this.metroPanel1.Controls.Add(this.txtFullname);
            this.metroPanel1.Controls.Add(this.dungeonLabel1);
            this.metroPanel1.IsDerivedStyle = true;
            this.metroPanel1.Location = new System.Drawing.Point(232, 114);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(556, 433);
            this.metroPanel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroPanel1.StyleManager = null;
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.ThemeAuthor = "Taiizor";
            this.metroPanel1.ThemeName = "MetroLight";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnAddCustomer.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCustomer.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnAddCustomer.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnAddCustomer.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnAddCustomer.Location = new System.Drawing.Point(152, 359);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.PrimaryColor = System.Drawing.Color.RoyalBlue;
            this.btnAddCustomer.Size = new System.Drawing.Size(229, 40);
            this.btnAddCustomer.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnAddCustomer.TabIndex = 26;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.TextColor = System.Drawing.Color.White;
            this.btnAddCustomer.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // picCustomer
            // 
            this.picCustomer.Image = global::Laundry.Properties.Resources.account;
            this.picCustomer.Location = new System.Drawing.Point(210, 27);
            this.picCustomer.Name = "picCustomer";
            this.picCustomer.Size = new System.Drawing.Size(133, 115);
            this.picCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCustomer.TabIndex = 11;
            this.picCustomer.TabStop = false;
            this.picCustomer.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rdoGender2
            // 
            this.rdoGender2.AutoSize = true;
            this.rdoGender2.BackColor = System.Drawing.Color.White;
            this.rdoGender2.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.rdoGender2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoGender2.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.rdoGender2.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.rdoGender2.Enable = true;
            this.rdoGender2.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.rdoGender2.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.rdoGender2.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.rdoGender2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGender2.ForeColor = System.Drawing.Color.Black;
            this.rdoGender2.Location = new System.Drawing.Point(101, 307);
            this.rdoGender2.Name = "rdoGender2";
            this.rdoGender2.Size = new System.Drawing.Size(74, 20);
            this.rdoGender2.TabIndex = 24;
            this.rdoGender2.TabStop = true;
            this.rdoGender2.Text = "Female";
            this.rdoGender2.UseVisualStyleBackColor = false;
            // 
            // rdoGender1
            // 
            this.rdoGender1.AutoSize = true;
            this.rdoGender1.BackColor = System.Drawing.Color.White;
            this.rdoGender1.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.rdoGender1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoGender1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.rdoGender1.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.rdoGender1.Enable = true;
            this.rdoGender1.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.rdoGender1.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.rdoGender1.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.rdoGender1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoGender1.ForeColor = System.Drawing.Color.Black;
            this.rdoGender1.Location = new System.Drawing.Point(33, 307);
            this.rdoGender1.Name = "rdoGender1";
            this.rdoGender1.Size = new System.Drawing.Size(62, 20);
            this.rdoGender1.TabIndex = 23;
            this.rdoGender1.TabStop = true;
            this.rdoGender1.Text = "Male";
            this.rdoGender1.UseVisualStyleBackColor = false;
            // 
            // dateBirthdate
            // 
            this.dateBirthdate.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBirthdate.Location = new System.Drawing.Point(291, 310);
            this.dateBirthdate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateBirthdate.Name = "dateBirthdate";
            this.dateBirthdate.Size = new System.Drawing.Size(229, 29);
            this.dateBirthdate.TabIndex = 22;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.BackColor = System.Drawing.Color.White;
            this.txtContactNumber.BaseColor = System.Drawing.Color.LightGray;
            this.txtContactNumber.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtContactNumber.BorderColorB = System.Drawing.Color.LightGray;
            this.txtContactNumber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtContactNumber.Hint = "";
            this.txtContactNumber.Location = new System.Drawing.Point(291, 241);
            this.txtContactNumber.MaxLength = 32767;
            this.txtContactNumber.Multiline = false;
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.PasswordChar = '\0';
            this.txtContactNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContactNumber.SelectedText = "";
            this.txtContactNumber.SelectionLength = 0;
            this.txtContactNumber.SelectionStart = 0;
            this.txtContactNumber.Size = new System.Drawing.Size(229, 34);
            this.txtContactNumber.TabIndex = 18;
            this.txtContactNumber.TabStop = false;
            this.txtContactNumber.UseSystemPasswordChar = false;
            // 
            // dungeonLabel6
            // 
            this.dungeonLabel6.AutoSize = true;
            this.dungeonLabel6.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel6.Location = new System.Drawing.Point(33, 291);
            this.dungeonLabel6.Name = "dungeonLabel6";
            this.dungeonLabel6.Size = new System.Drawing.Size(45, 13);
            this.dungeonLabel6.TabIndex = 12;
            this.dungeonLabel6.Text = "Gender";
            // 
            // dungeonLabel3
            // 
            this.dungeonLabel3.AutoSize = true;
            this.dungeonLabel3.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel3.Location = new System.Drawing.Point(288, 225);
            this.dungeonLabel3.Name = "dungeonLabel3";
            this.dungeonLabel3.Size = new System.Drawing.Size(93, 13);
            this.dungeonLabel3.TabIndex = 13;
            this.dungeonLabel3.Text = "Contact Number";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtEmail.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtEmail.BorderColorB = System.Drawing.Color.LightGray;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(291, 178);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(229, 34);
            this.txtEmail.TabIndex = 19;
            this.txtEmail.TabStop = false;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // dungeonLabel5
            // 
            this.dungeonLabel5.AutoSize = true;
            this.dungeonLabel5.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel5.Location = new System.Drawing.Point(288, 291);
            this.dungeonLabel5.Name = "dungeonLabel5";
            this.dungeonLabel5.Size = new System.Drawing.Size(55, 13);
            this.dungeonLabel5.TabIndex = 14;
            this.dungeonLabel5.Text = "Birthdate";
            // 
            // dungeonLabel4
            // 
            this.dungeonLabel4.AutoSize = true;
            this.dungeonLabel4.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel4.Location = new System.Drawing.Point(288, 162);
            this.dungeonLabel4.Name = "dungeonLabel4";
            this.dungeonLabel4.Size = new System.Drawing.Size(35, 13);
            this.dungeonLabel4.TabIndex = 15;
            this.dungeonLabel4.Text = "Email";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtAddress.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtAddress.BorderColorB = System.Drawing.Color.LightGray;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtAddress.Hint = "";
            this.txtAddress.Location = new System.Drawing.Point(32, 241);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Multiline = false;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.Size = new System.Drawing.Size(229, 34);
            this.txtAddress.TabIndex = 20;
            this.txtAddress.TabStop = false;
            this.txtAddress.UseSystemPasswordChar = false;
            // 
            // dungeonLabel2
            // 
            this.dungeonLabel2.AutoSize = true;
            this.dungeonLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel2.Location = new System.Drawing.Point(29, 225);
            this.dungeonLabel2.Name = "dungeonLabel2";
            this.dungeonLabel2.Size = new System.Drawing.Size(49, 13);
            this.dungeonLabel2.TabIndex = 16;
            this.dungeonLabel2.Text = "Address";
            // 
            // txtFullname
            // 
            this.txtFullname.BackColor = System.Drawing.Color.White;
            this.txtFullname.BaseColor = System.Drawing.Color.Transparent;
            this.txtFullname.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtFullname.BorderColorB = System.Drawing.Color.LightGray;
            this.txtFullname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtFullname.Hint = "";
            this.txtFullname.Location = new System.Drawing.Point(32, 178);
            this.txtFullname.MaxLength = 32767;
            this.txtFullname.Multiline = false;
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.PasswordChar = '\0';
            this.txtFullname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFullname.SelectedText = "";
            this.txtFullname.SelectionLength = 0;
            this.txtFullname.SelectionStart = 0;
            this.txtFullname.Size = new System.Drawing.Size(229, 34);
            this.txtFullname.TabIndex = 21;
            this.txtFullname.TabStop = false;
            this.txtFullname.UseSystemPasswordChar = false;
            this.txtFullname.Click += new System.EventHandler(this.txtFullname_Click);
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dungeonLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel1.Location = new System.Drawing.Point(29, 162);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(60, 13);
            this.dungeonLabel1.TabIndex = 17;
            this.dungeonLabel1.Text = "Full Name";
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
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 585);
            this.panel1.TabIndex = 3;
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 577);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.label1);
            this.Name = "CustomerForm";
            this.Text = "Laundry System | Customer Form";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox picCustomer;
        private ReaLTaiizor.Controls.HopeRadioButton rdoGender2;
        private ReaLTaiizor.Controls.HopeRadioButton rdoGender1;
        private ReaLTaiizor.Controls.PoisonDateTime dateBirthdate;
        private ReaLTaiizor.Controls.HopeTextBox txtContactNumber;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel6;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel3;
        private ReaLTaiizor.Controls.HopeTextBox txtEmail;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel5;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel4;
        private ReaLTaiizor.Controls.HopeTextBox txtAddress;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private ReaLTaiizor.Controls.HopeTextBox txtFullname;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.HopeButton btnAddCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ReaLTaiizor.Controls.RoyalButton btnDashboardLink;
        private ReaLTaiizor.Controls.RoyalButton btnGarmentTypeLink;
        private ReaLTaiizor.Controls.RoyalButton btnLaundryLink;
        private ReaLTaiizor.Controls.RoyalButton btnCustomerLink;
        private ReaLTaiizor.Controls.RoyalButton btnServiceTypeLink;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}