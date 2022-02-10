using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class AddPharmacist : Form
    {
        public AddPharmacist()
        {
            InitializeComponent();
        }

        private void customerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pharmacistNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void add_button_click(object sender, EventArgs e)
        {
            bool error =false;
            if (name.Text == String.Empty || age.Text == String.Empty || id.Text == String.Empty || number.Text == String.Empty || address.Text == String.Empty || bonus.Text == String.Empty || workingHours.Text == String.Empty || salary.Text == String.Empty || shift.Text == String.Empty|| speciality.Text == String.Empty)
            {
                error = true;
                errorMessage.ForeColor = System.Drawing.Color.Red;
                errorMessage.Text = "Fill All Inputs";
                return;
            }
            string str = "";
            if (female_button.Checked) { str = "female"; }
            if(male_button.Checked) { str = "male"; }
            if (!error)
            {
                Dashboard.allStaffMembers.Add(new Pharmacist(name.Text.ToLower(), Convert.ToInt32(age.Text), id.Text.ToLower(), address.Text.ToLower(), number.Text, str, Convert.ToDouble(workingHours.Text), Convert.ToDouble(salary.Text), Convert.ToDouble(bonus.Text), shift.Text.ToLower(), speciality.Text.ToLower()));
                errorMessage.ForeColor = System.Drawing.Color.Green;
                errorMessage.Text = "Pharmacist Added Successfully.";
            }
        }

        private void cancel_button_click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void AddPharmacist_Load(object sender, EventArgs e)
        {

        }
    }
}
