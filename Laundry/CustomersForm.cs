using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
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
    public partial class CustomersForm : Form
    {
        GlobalProcedure globalProcedure = new GlobalProcedure();
        public CustomersForm()
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

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            CustomersForm customerForm = new CustomersForm();
            customerForm.ShowDialog();
        }

        private void btnSearchCustomers_Click(object sender, EventArgs e)
        {
            MySqlCommand sqlCmd = this.globalProcedure.sqlCommand;
           
            try
            {
                sqlCmd.Parameters.Clear();
                sqlCmd.CommandText = "procSearchCustomer";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@p_fullname", txtQuery.Text);


                DataTable table = new DataTable();
                table.Columns.Add("id".ToString());
                table.Columns.Add("Full Name".ToString());
                table.Columns.Add("Email".ToString());
                table.Columns.Add("Address".ToString());
                table.Columns.Add("Contact Number".ToString());
                table.Columns.Add("Gender".ToString());
                table.Columns.Add("Birthdate".ToString());

                using (var reader = sqlCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DataRow dr = table.NewRow();
                        dr["id"] = "test";
                        dr["Full Name"] = reader.GetString(reader.GetOrdinal("fullname"));
                        dr["Email"] = reader.GetString(reader.GetOrdinal("emailadd"));
                        dr["Address"] = reader.GetString(reader.GetOrdinal("address"));
                        dr["Contact Number"] = reader.GetString(reader.GetOrdinal("contactno"));
                        // dr["Birthdate"] = reader.GetString(reader.GetOrdinal("birthdate"));
                        dr["Birthdate"] = "test";
                        table.Rows.Add(dr);
                    }
                }

                dgridCustomers.DataSource = table;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            globalProcedure.checkDatabaseConnection();
        }
    }
}
