using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class AddCashier : Form
    {
        public AddCashier()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void add_cashier_click(object sender, EventArgs e)
        {
            bool error = false;
            if (name.Text == String.Empty|| age.Text == String.Empty || id.Text == String.Empty || number.Text == String.Empty || address.Text== String.Empty || bonus.Text == String.Empty || workinghours.Text == String.Empty || salary.Text == String.Empty || shift.Text == String.Empty ) 
            {
                error = true;
                errorMessage.ForeColor = System.Drawing.Color.Red;
                errorMessage.Text = "Fill All Inputs";
                return; 
            }
            string str = "";
            if (female_button.Checked) { str = "female"; }
            if (male_button.Checked) { str = "male"; }
            if (!error)
            {
                Dashboard.allStaffMembers.Add(new Cashier(name.Text.ToLower(), Convert.ToInt32(age.Text), id.Text.ToLower(), address.Text.ToLower(), number.Text.ToLower(), str, Convert.ToDouble(workinghours.Text), Convert.ToDouble(salary.Text), Convert.ToDouble(bonus.Text), shift.Text.ToLower()));
                errorMessage.ForeColor = System.Drawing.Color.Green;
                errorMessage.Text = "Cashier Added Successfully.";
            }


        }

        private void cancel_click_button(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void cashier_id_Click(object sender, EventArgs e)
        {

        }

        private void AddCashier_Load(object sender, EventArgs e)
        {

        }
    }
}
