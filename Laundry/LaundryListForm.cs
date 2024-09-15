using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry
{
    public partial class LaundryListForm : Form
    {
        public LaundryListForm()
        {
            InitializeComponent();
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

        private void btnAddLaundry_Click(object sender, EventArgs e)
        {
            LaundryForm laundryForm = new LaundryForm();
            laundryForm.ShowDialog();
        }
    }
}
