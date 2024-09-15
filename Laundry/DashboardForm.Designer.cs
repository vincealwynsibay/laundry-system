namespace Laundry
{
    partial class DashboardForm
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddLaundry = new ReaLTaiizor.Controls.RoyalButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(223, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 197);
            this.dataGridView1.TabIndex = 27;
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
            this.panel1.Location = new System.Drawing.Point(2, -41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 492);
            this.panel1.TabIndex = 28;
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
            this.btnLaundryLink.Location = new System.Drawing.Point(-78, 230);
            this.btnLaundryLink.Name = "btnLaundryLink";
            this.btnLaundryLink.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnLaundryLink.PressedForeColor = System.Drawing.Color.White;
            this.btnLaundryLink.Size = new System.Drawing.Size(264, 40);
            this.btnLaundryLink.TabIndex = 6;
            this.btnLaundryLink.Text = "Laundry";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 30);
            this.label1.TabIndex = 29;
            this.label1.Text = "Laundry List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(223, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 121);
            this.panel2.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(54, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 50);
            this.label2.TabIndex = 29;
            this.label2.Text = "29";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 30);
            this.label3.TabIndex = 29;
            this.label3.Text = "Orders";
            // 
            // btnAddLaundry
            // 
            this.btnAddLaundry.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddLaundry.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnAddLaundry.BorderThickness = 3;
            this.btnAddLaundry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddLaundry.DrawBorder = true;
            this.btnAddLaundry.ForeColor = System.Drawing.Color.White;
            this.btnAddLaundry.HotTrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnAddLaundry.Image = null;
            this.btnAddLaundry.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
            this.btnAddLaundry.Location = new System.Drawing.Point(580, 180);
            this.btnAddLaundry.Name = "btnAddLaundry";
            this.btnAddLaundry.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnAddLaundry.PressedForeColor = System.Drawing.Color.White;
            this.btnAddLaundry.Size = new System.Drawing.Size(86, 34);
            this.btnAddLaundry.TabIndex = 31;
            this.btnAddLaundry.Text = "NEW +";
            this.btnAddLaundry.Click += new System.EventHandler(this.btnAddLaundry_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(412, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 121);
            this.panel3.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(65, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 50);
            this.label4.TabIndex = 29;
            this.label4.Text = "9";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 30);
            this.label5.TabIndex = 29;
            this.label5.Text = "Delivered";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(603, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 121);
            this.panel4.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(54, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 50);
            this.label6.TabIndex = 29;
            this.label6.Text = "20";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 30);
            this.label7.TabIndex = 29;
            this.label7.Text = "Pending";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.btnAddLaundry);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GarmentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.RoyalButton btnServiceTypeLink;
        private ReaLTaiizor.Controls.RoyalButton btnGarmentTypeLink;
        private ReaLTaiizor.Controls.RoyalButton btnLaundryLink;
        private ReaLTaiizor.Controls.RoyalButton btnCustomerLink;
        private ReaLTaiizor.Controls.RoyalButton btnDashboardLink;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private ReaLTaiizor.Controls.RoyalButton btnAddLaundry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}