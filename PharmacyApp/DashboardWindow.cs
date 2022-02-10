using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class DashboardWindow : Form
    {
        public DashboardWindow()
        {
            InitializeComponent();
            totalBalanceLabel.Text = $"{Convert.ToString(Dashboard.TotalBalance)}$";
            if (Dashboard.AllCustomers == null)
                allCustomersTable.Hide();
            else
            allCustomersTable.DataSource = Dashboard.AllCustomers;
            if (Dashboard.AllProducts == null)
                allProductsTable.Hide();
            else
                allProductsTable.DataSource = Dashboard.AllProducts;
            if (Dashboard.allStaffMembers == null)
                allStaffMembersTable.Hide();
            else
                allStaffMembersTable.DataSource = Dashboard.allStaffMembers;
        }
        private void backButtonHandler(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
