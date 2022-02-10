using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dashboard_Click(object sender, EventArgs e)
        {

        }

        private void productsButtonHandler(object sender, EventArgs e)
        {
            ProductsMenu p = new ProductsMenu();
            p.ShowDialog();
        }

        private void customersButtonHandler(object sender, EventArgs e)
        {
            CustomerMenu c = new CustomerMenu();
            c.ShowDialog();
        }

        private void staffButtonHandler(object sender, EventArgs e)
        {
            StaffMenu s = new StaffMenu();
            s.ShowDialog();
        }

        private void dashboardButtonHandler(object sender, EventArgs e)
        {
            DashboardWindow d = new DashboardWindow();
            d.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
