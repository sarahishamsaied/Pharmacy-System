using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void saveButtonHandler(object sender, EventArgs e)
        {
            bool error = false;
            if (doesExist(customerId.Text))
            {
                error = true;
                statusMessage.ForeColor = System.Drawing.Color.Red;
                statusMessage.Text = "This customer already exists!";
                return;
            }
            if(!isNumeric(customerAge.Text))
            {
                error = true;
                statusMessage.ForeColor = System.Drawing.Color.Red;
                statusMessage.Text = $"{int.TryParse(customerAge.Text,out _)}Phone number and age shoud be\n numeric values!";
                return;
            }
            
            if(!doesExist(customerId.Text)&&!error)
            {
                string gender = null;
                if (male.Checked)
                    gender = "Male";
                if (female.Checked)
                    gender = "Female";
                Dashboard.AllCustomers.Add(new Customer(customerName.Text.ToLower(), Convert.ToInt32(customerAge.Text), customerId.Text.ToLower(), customerAddress.Text.ToLower(), customerNumber.Text.ToLower(), gender.ToLower()));
                statusMessage.ForeColor = System.Drawing.Color.Green;
                statusMessage.Text = "Customer Added Successfully";
                return;
            }
        }
        bool doesExist(string code)
        {
            return Dashboard.AllCustomers.Exists(item => code == item.Id);
        }
        bool isNumeric(string str)
        {
            return int.TryParse(str, out _);
        }
        private void cancelButtonHandler(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
