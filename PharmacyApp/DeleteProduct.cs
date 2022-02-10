using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class DeleteProduct : Form
    {
        public DeleteProduct()
        {
            InitializeComponent();
        }

        private void deleteProductButtonHandler(object sender, EventArgs e)
        {
            bool found = false;
            Dashboard.AllProducts.Find(item => productId.Text == item.ProductCode);
            for(int i = 0; i < Dashboard.AllProducts.Count; i++)
            {
                if(Dashboard.AllProducts[i].ProductCode == productId.Text)
                {
                    found = true;
                    Dashboard.AllProducts.Remove(Dashboard.AllProducts[i]);
                }
            }
            if (!found)
            {
                statusMessage.ForeColor = System.Drawing.Color.Red;
                statusMessage.Text = "Product not found";
            }
            else
            {
                statusMessage.ForeColor = System.Drawing.Color.Green;
                statusMessage.Text = "Success";
            }
        }

        private void cancelButtonHandler(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
