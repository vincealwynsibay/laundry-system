using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry
{
    public partial class CustomerForm : Form
    {
        GlobalProcedure globalProcedure = new GlobalProcedure();
        string imgCustomer = "";
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            globalProcedure.checkDatabaseConnection();
        }

        private void hopeRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialogProfilePic = new OpenFileDialog();
            fileDialogProfilePic.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg"; ;
            if (fileDialogProfilePic.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                picCustomer.BackgroundImage = new Bitmap(fileDialogProfilePic.FileName);
                picCustomer.Image = new Bitmap(fileDialogProfilePic.FileName);
                imgCustomer = fileDialogProfilePic.FileName;
            }
        }

        private void btnDashboardLink_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            this.Hide();
            dashboardForm.Show();
        }

        private void btnCustomerLink_Click(object sender, EventArgs e)
        {
            CustomersForm customerForm = new CustomersForm();
            this.Hide();
            customerForm.Show();
        }

        private void btnLaundryLink_Click(object sender, EventArgs e)
        {
            LaundryListForm laundryListForm = new LaundryListForm();
            this.Hide();
            laundryListForm.Show();
        }

        private void btnGarmentTypeLink_Click(object sender, EventArgs e)
        {
            GarmentForm garmentForm = new GarmentForm();
            this.Hide();
            garmentForm.Show();
        }

        private void btnServiceTypeLink_Click(object sender, EventArgs e)
        {
            ServiceForm serviceForm = new ServiceForm();
            this.Hide();
            serviceForm.Show();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            MySqlCommand sqlCmd = this.globalProcedure.sqlCommand;
            bool isChecked = rdoGender1.Checked;
            string gender = "";
            if (isChecked)
                gender = rdoGender1.Text;
            else
                gender = rdoGender2.Text;

            try
            {
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = "procAddCustomer";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@p_fullname", txtFullname.Text);
                sqlCmd.Parameters.AddWithValue("@p_birthdate", (DateTime) dateBirthdate.Value);
                sqlCmd.Parameters.AddWithValue("@p_gender", gender);
                sqlCmd.Parameters.AddWithValue("@p_address", txtAddress.Text);
                sqlCmd.Parameters.AddWithValue("@p_contactno", txtContactNumber.Text);
                sqlCmd.Parameters.AddWithValue("@p_emailadd", txtEmail.Text);
                sqlCmd.Parameters.AddWithValue("@p_cust_photo", imgCustomer);
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtFullname_Click(object sender, EventArgs e)
        {
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
