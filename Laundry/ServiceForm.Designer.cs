namespace Laundry
{
    partial class ServiceForm
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
            this.txtServiceType = new ReaLTaiizor.Controls.HopeTextBox();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.metroPanel1 = new ReaLTaiizor.Controls.MetroPanel();
            this.txtDescription = new ReaLTaiizor.Controls.HopeRichTextBox();
            this.btnAddService = new ReaLTaiizor.Controls.HopeButton();
            this.dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            this.txtPrice = new ReaLTaiizor.Controls.HopeTextBox();
            this.dungeonLabel3 = new ReaLTaiizor.Controls.DungeonLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnServiceTypeLink = new ReaLTaiizor.Controls.RoyalButton();
            this.btnGarmentTypeLink = new ReaLTaiizor.Controls.RoyalButton();
            this.btnLaundryLink = new ReaLTaiizor.Controls.RoyalButton();
            this.btnCustomerLink = new ReaLTaiizor.Controls.RoyalButton();
            this.btnDashboardLink = new ReaLTaiizor.Controls.RoyalButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtServiceType
            // 
            this.txtServiceType.BackColor = System.Drawing.Color.White;
            this.txtServiceType.BaseColor = System.Drawing.Color.Transparent;
            this.txtServiceType.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtServiceType.BorderColorB = System.Drawing.Color.LightGray;
            this.txtServiceType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtServiceType.Hint = "";
            this.txtServiceType.Location = new System.Drawing.Point(26, 50);
            this.txtServiceType.MaxLength = 32767;
            this.txtServiceType.Multiline = false;
            this.txtServiceType.Name = "txtServiceType";
            this.txtServiceType.PasswordChar = '\0';
            this.txtServiceType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServiceType.SelectedText = "";
            this.txtServiceType.SelectionLength = 0;
            this.txtServiceType.SelectionStart = 0;
            this.txtServiceType.Size = new System.Drawing.Size(315, 34);
            this.txtServiceType.TabIndex = 21;
            this.txtServiceType.TabStop = false;
            this.txtServiceType.Text = "Enter Service Type";
            this.txtServiceType.UseSystemPasswordChar = false;
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dungeonLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel1.Location = new System.Drawing.Point(23, 34);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(71, 13);
            this.dungeonLabel1.TabIndex = 17;
            this.dungeonLabel1.Text = "Service Type";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackgroundColor = System.Drawing.Color.White;
            this.metroPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.metroPanel1.BorderThickness = 1;
            this.metroPanel1.Controls.Add(this.txtDescription);
            this.metroPanel1.Controls.Add(this.btnAddService);
            this.metroPanel1.Controls.Add(this.dungeonLabel2);
            this.metroPanel1.Controls.Add(this.txtPrice);
            this.metroPanel1.Controls.Add(this.dungeonLabel3);
            this.metroPanel1.Controls.Add(this.txtServiceType);
            this.metroPanel1.Controls.Add(this.dungeonLabel1);
            this.metroPanel1.IsDerivedStyle = true;
            this.metroPanel1.Location = new System.Drawing.Point(237, 114);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(373, 318);
            this.metroPanel1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroPanel1.StyleManager = null;
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.ThemeAuthor = "Taiizor";
            this.metroPanel1.ThemeName = "MetroLight";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtDescription.Hint = "";
            this.txtDescription.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtDescription.Location = new System.Drawing.Point(26, 113);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.Size = new System.Drawing.Size(315, 50);
            this.txtDescription.TabIndex = 23;
            this.txtDescription.TabStop = false;
            this.txtDescription.Text = "Enter Description";
            this.txtDescription.UseSystemPasswordChar = false;
            // 
            // btnAddService
            // 
            this.btnAddService.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnAddService.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.btnAddService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddService.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnAddService.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddService.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.btnAddService.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnAddService.Location = new System.Drawing.Point(26, 248);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.PrimaryColor = System.Drawing.Color.RoyalBlue;
            this.btnAddService.Size = new System.Drawing.Size(315, 40);
            this.btnAddService.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnAddService.TabIndex = 22;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.TextColor = System.Drawing.Color.White;
            this.btnAddService.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            // 
            // dungeonLabel2
            // 
            this.dungeonLabel2.AutoSize = true;
            this.dungeonLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dungeonLabel2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel2.Location = new System.Drawing.Point(23, 95);
            this.dungeonLabel2.Name = "dungeonLabel2";
            this.dungeonLabel2.Size = new System.Drawing.Size(66, 13);
            this.dungeonLabel2.TabIndex = 17;
            this.dungeonLabel2.Text = "Description";
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
            this.txtPrice.Location = new System.Drawing.Point(26, 192);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Multiline = false;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.Size = new System.Drawing.Size(315, 34);
            this.txtPrice.TabIndex = 21;
            this.txtPrice.TabStop = false;
            this.txtPrice.Text = "Enter Price";
            this.txtPrice.UseSystemPasswordChar = false;
            // 
            // dungeonLabel3
            // 
            this.dungeonLabel3.AutoSize = true;
            this.dungeonLabel3.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dungeonLabel3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dungeonLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel3.Location = new System.Drawing.Point(23, 176);
            this.dungeonLabel3.Name = "dungeonLabel3";
            this.dungeonLabel3.Size = new System.Drawing.Size(50, 13);
            this.dungeonLabel3.TabIndex = 17;
            this.dungeonLabel3.Text = "Price (₱)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add Service";
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
            this.panel1.Size = new System.Drawing.Size(199, 510);
            this.panel1.TabIndex = 7;
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
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 458);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.label1);
            this.Name = "ServiceForm";
            this.Text = "ServiceForm";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.HopeTextBox txtServiceType;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.MetroPanel metroPanel1;
        private ReaLTaiizor.Controls.HopeButton btnAddService;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.HopeRichTextBox txtDescription;
        private ReaLTaiizor.Controls.HopeTextBox txtPrice;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel3;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.RoyalButton btnServiceTypeLink;
        private ReaLTaiizor.Controls.RoyalButton btnGarmentTypeLink;
        private ReaLTaiizor.Controls.RoyalButton btnLaundryLink;
        private ReaLTaiizor.Controls.RoyalButton btnCustomerLink;
        private ReaLTaiizor.Controls.RoyalButton btnDashboardLink;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}