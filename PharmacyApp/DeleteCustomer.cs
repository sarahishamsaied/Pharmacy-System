using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class DeleteCustomer : Form
    {
        public DeleteCustomer()
        {
            InitializeComponent();
        }

        private void deleteCustomerButtonHandler(object sender, EventArgs e)
        {
            bool found = false;
            for(int i = 0; i < Dashboard.AllCustomers.Count; i++)
            {
                if(customerId.Text == Dashboard.AllCustomers[i].Id)
                {
                    found = true;
                    Dashboard.AllCustomers.Remove(Dashboard.AllCustomers[i]);
                    statusMessage.ForeColor = System.Drawing.Color.Green;
                    statusMessage.Text = "Customer removed successfully";

                }
            }
            if (!found)
            {
                statusMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }
        }

        private void cancelButtonHandler(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
