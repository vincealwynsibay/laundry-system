namespace Laundry
{
    partial class LaundryForm
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
            this.User = new ReaLTaiizor.Controls.DungeonLabel();
            this.metroPanel1 = new ReaLTaiizor.Controls.MetroPanel();
            this.hopeComboBox2 = new ReaLTaiizor.Controls.HopeComboBox();
            this.hopeComboBox3 = new ReaLTaiizor.Controls.HopeComboBox();
            this.hopeComboBox1 = new ReaLTaiizor.Controls.HopeComboBox();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.btnAddLaundry = new ReaLTaiizor.Controls.HopeButton();
            this.dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            this.txtPrice = new ReaLTaiizor.Controls.HopeTextBox();
            this.dungeonLabel3 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GarmentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnServiceTypeLink = new ReaLTaiizor.Controls.RoyalButton();
            this.btnGarmentTypeLink = new ReaLTaiizor.Controls.RoyalButton();
            this.btnLaundryLink = new ReaLTaiizor.Controls.RoyalButton();
            this.btnCustomerLink = new ReaLTaiizor.Controls.RoyalButton();
            this.btnDashboardLink = new ReaLTaiizor.Controls.RoyalButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.BackColor = System.Drawing.Color.Transparent;
            this.User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.User.Location = new System.Drawing.Point(34, 43);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(30, 13);
            this.User.TabIndex = 17;
            this.User.Text = "User";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundColor = System.Drawing.Color.White;
            this.metroPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroPanel1.BorderThickness = 1;
            this.metroPanel1.Controls.Add(this.hopeComboBox2);
            this.metroPanel1.Controls.Add(this.hopeComboBox3);
            this.metroPanel1.Controls.Add(this.hopeComboBox1);
            this.metroPanel1.Controls.Add(this.dungeonLabel1);
            this.metroPanel1.Controls.Add(this.btnAddLaundry);
            this.metroPanel1.Controls.Add(this.dungeonLabel2);
            this.metroPanel1.Controls.Add(this.txtPrice);
            this.metroPanel1.Controls.Add(this.dungeonLabel3);
            this.metroPanel1.Controls.Add(this.User);
            this.metroPanel1.IsDerivedStyle = true;
            this.metroPanel1.Location = new System.Drawing.Point(239, 86);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(296, 395);
            this.metroPanel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroPanel1.StyleManager = null;
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.ThemeAuthor = "Taiizor";
            this.metroPanel1.ThemeName = "MetroLight";
            // 
            // hopeComboBox2
            // 
            this.hopeComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.hopeComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.hopeComboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hopeComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hopeComboBox2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeComboBox2.FormattingEnabled = true;
            this.hopeComboBox2.ItemHeight = 30;
            this.hopeComboBox2.Location = new System.Drawing.Point(37, 59);
            this.hopeComboBox2.Name = "hopeComboBox2";
            this.hopeComboBox2.Size = new System.Drawing.Size(229, 36);
            this.hopeComboBox2.TabIndex = 24;
            // 
            // hopeComboBox3
            // 
            this.hopeComboBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hopeComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hopeComboBox3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeComboBox3.FormattingEnabled = true;
            this.hopeComboBox3.ItemHeight = 30;
            this.hopeComboBox3.Location = new System.Drawing.Point(37, 132);
            this.hopeComboBox3.Name = "hopeComboBox3";
            this.hopeComboBox3.Size = new System.Drawing.Size(229, 36);
            this.hopeComboBox3.TabIndex = 23;
            this.hopeComboBox3.SelectedIndexChanged += new System.EventHandler(this.hopeComboBox3_SelectedIndexChanged);
            // 
            // hopeComboBox1
            // 
            this.hopeComboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hopeComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hopeComboBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeComboBox1.FormattingEnabled = true;
            this.hopeComboBox1.ItemHeight = 30;
            this.hopeComboBox1.Location = new System.Drawing.Point(37, 199);
            this.hopeComboBox1.Name = "hopeComboBox1";
            this.hopeComboBox1.Size = new System.Drawing.Size(229, 36);
            this.hopeComboBox1.TabIndex = 23;
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dungeonLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel1.Location = new System.Drawing.Point(34, 107);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(71, 13);
            this.dungeonLabel1.TabIndex = 17;
            this.dungeonLabel1.Text = "Service Type";
            this.dungeonLabel1.Click += new System.EventHandler(this.dungeonLabel1_Click);
            // 
            // btnAddLaundry
            // 
            this.btnAddLaundry.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnAddLaundry.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnAddLaundry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddLaundry.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnAddLaundry.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddLaundry.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLaundry.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnAddLaundry.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnAddLaundry.Location = new System.Drawing.Point(37, 327);
            this.btnAddLaundry.Name = "btnAddLaundry";
            this.btnAddLaundry.PrimaryColor = System.Drawing.Color.RoyalBlue;
            this.btnAddLaundry.Size = new System.Drawing.Size(229, 40);
            this.btnAddLaundry.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnAddLaundry.TabIndex = 22;
            this.btnAddLaundry.Text = "Add Service";
            this.btnAddLaundry.TextColor = System.Drawing.Color.White;
            this.btnAddLaundry.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            // 
            // dungeonLabel2
            // 
            this.dungeonLabel2.AutoSize = true;
            this.dungeonLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dungeonLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel2.Location = new System.Drawing.Point(34, 174);
            this.dungeonLabel2.Name = "dungeonLabel2";
            this.dungeonLabel2.Size = new System.Drawing.Size(80, 13);
            this.dungeonLabel2.TabIndex = 17;
            this.dungeonLabel2.Text = "Garment Type";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.BaseColor = System.Drawing.Color.Transparent;
            this.txtPrice.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtPrice.BorderColorB = System.Drawing.Color.LightGray;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtPrice.Hint = "";
            this.txtPrice.Location = new System.Drawing.Point(37, 271);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.Size = new System.Drawing.Size(229, 34);
            this.txtPrice.TabIndex = 21;
            this.txtPrice.TabStop = false;
            this.txtPrice.Text = "Enter Quantity";
            this.txtPrice.UseSystemPasswordChar = false;
            // 
            // dungeonLabel3
            // 
            this.dungeonLabel3.AutoSize = true;
            this.dungeonLabel3.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dungeonLabel3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel3.Location = new System.Drawing.Point(34, 255);
            this.dungeonLabel3.Name = "dungeonLabel3";
            this.dungeonLabel3.Size = new System.Drawing.Size(52, 13);
            this.dungeonLabel3.TabIndex = 17;
            this.dungeonLabel3.Text = "Quantity";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GarmentType,
            this.ServiceType,
            this.Quantity,
            this.Amount});
            this.dataGridView1.Location = new System.Drawing.Point(580, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 395);
            this.dataGridView1.TabIndex = 9;
            // 
            // GarmentType
            // 
            this.GarmentType.HeaderText = "Garment Type";
            this.GarmentType.Name = "GarmentType";
            // 
            // ServiceType
            // 
            this.ServiceType.HeaderText = "Service Type";
            this.ServiceType.Name = "ServiceType";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
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
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 528);
            this.panel1.TabIndex = 10;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add Laundry";
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
            // LaundryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "LaundryForm";
            this.Text = "LaundryForm";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.DungeonLabel User;
        private ReaLTaiizor.Controls.MetroPanel metroPanel1;
        private ReaLTaiizor.Controls.HopeButton btnAddLaundry;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private ReaLTaiizor.Controls.HopeTextBox txtPrice;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GarmentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBox2;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBox3;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBox1;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.RoyalButton btnServiceTypeLink;
        private ReaLTaiizor.Controls.RoyalButton btnGarmentTypeLink;
        private ReaLTaiizor.Controls.RoyalButton btnLaundryLink;
        private ReaLTaiizor.Controls.RoyalButton btnCustomerLink;
        private ReaLTaiizor.Controls.RoyalButton btnDashboardLink;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}