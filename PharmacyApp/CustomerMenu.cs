using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class CustomerMenu : Form
    {
        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void addCustomerButtonHandler(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void openDeleteCustomerForm(object sender, EventArgs e)
        {
            DeleteCustomer d = new DeleteCustomer();
            d.ShowDialog();
        }

        private void viewAllCustomersHandler(object sender, EventArgs e)
        {
            ViewCustomers d = new ViewCustomers();
            d.ShowDialog();
        }
    }
}
