using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class ProductsMenu : Form
    {
        public ProductsMenu()
        {
            InitializeComponent();
        }

        private void sellProductButtonHandler(object sender, EventArgs e)
        {
            SellProduct s = new SellProduct();
            s.ShowDialog();
        }

        private void addProductButtonHandler(object sender, EventArgs e)
        {
            AddProduct p = new AddProduct();
            p.ShowDialog();
        }

        private void removeProductButtonHandler(object sender, EventArgs e)
        {
            DeleteProduct d = new DeleteProduct();
            d.ShowDialog();
        }

        private void viewAllProductsButtonHandler(object sender, EventArgs e)
        {
            ViewProduct d = new ViewProduct();
            d.ShowDialog();
        }

        private void goBackButtonHandler(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
