using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class SellProduct : Form
    {
        
        public SellProduct()
        {
            InitializeComponent();
            printButton.Enabled = false;
        }

        private void sellProductButtonHandler(object sender, EventArgs e)
        {
            if(productCode.Text == String.Empty || buyerName.Text == String.Empty)
            {
                statusMessage.ForeColor = System.Drawing.Color.Red;
                statusMessage.Text = "Please fill all inputs";
                return;

            }
            if (GetProductData(productCode.Text) == null)
            {
                cannotFindProduct.ForeColor = System.Drawing.Color.Red;
                cannotFindProduct.Text = "Can't find product";
                return;
            }
            if (GetProductData(productCode.Text).Quantity == 0) {
                statusMessage.ForeColor = System.Drawing.Color.Red;
                statusMessage.Text = "Product is no longer available";
                Dashboard.AllProducts.Remove(GetProductData(productCode.Text));
                return;
            }
            else
            {
                printButton.Enabled = true;
                statusMessage.ForeColor = System.Drawing.Color.Green;
                statusMessage.Text = "Product Sold Successfully!";
                Product foundProduct = GetProductData(productCode.Text);
                Sell s = new Sell(productCode.Text, buyerName.Text);
                Dashboard.TotalBalance += foundProduct.Price;
                foundProduct.Quantity--;
                return;
            }
        }
        public Product GetProductData(string code)
        {
            return Dashboard.AllProducts.Find(val => code == val.ProductCode);
        }

        private void cancelButtonHandler(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printButtonHandler(object sender, EventArgs e)
        {
            PrintReceipt p = new PrintReceipt(productCode.Text,buyerName.Text);
            p.ShowDialog();
        }
    }
}
