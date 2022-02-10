using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void productQuantityLabel_Click(object sender, EventArgs e)
        {

        }

        private void productQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void addProductButtonHandler(object sender, EventArgs e)
        {
            bool error = false;
            if (productName.Text == String.Empty || productCode.Text == String.Empty || product_Price.Text == String.Empty || productType.Text == String.Empty || productSupplier.Text == String.Empty || productDiscount.Text == String.Empty)
            {
                errorMessage.Text = "Please Fill All Inputs.";
                errorMessage.ForeColor = System.Drawing.Color.Red;
                error = true;
                return;
            }
            if (!isNumeric(productQuantity.Text) || !isNumeric(product_Price.Text) || !isNumeric(productDiscount.Text))
            {
                error = true;
                errorMessage.ForeColor = System.Drawing.Color.Red;
                errorMessage.Text = $"Quantity/Price/Discount\nshould be numeric values";
                return;
            }
            if (doesExist(productCode.Text))
            {
                error = true;
                errorMessage.ForeColor = System.Drawing.Color.Red;
                errorMessage.Text = "Product Already Exists";
                return;
            }
                
            if (!error && !doesExist(productCode.Text))
            {
                Dashboard.AllProducts.Add(new Product(productName.Text.ToLower(), productCode.Text.ToLower(), Convert.ToDouble(product_Price.Text), productType.Text.ToLower(), productSupplier.Text.ToLower(), Convert.ToDouble(productDiscount.Text),Convert.ToDouble(productQuantity.Text),dateTimePicker1.Value.ToShortDateString()));
                errorMessage.ForeColor = System.Drawing.Color.Green;
                errorMessage.Text = "Product Added Successfully.";
                return;
            }


        }
        bool isNumeric(string str)
        {
            return Double.TryParse(str, out _);
        }
        bool doesExist(string code)
        {
            bool state = false;
            if (Dashboard.AllProducts.Count == 0)
                return state;
            if (Dashboard.AllProducts.Exists(item =>code == item.ProductCode))
            {
                state = true;
            }
            return state;
        }
        private void cancelButtonHandler(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backButtonHandler(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
