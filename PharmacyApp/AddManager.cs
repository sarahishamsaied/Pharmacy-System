using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class AddManager : Form
    {
        public AddManager()
        {
            InitializeComponent();
        }

        private void addButton_click(object sender, EventArgs e)
        {
            bool error = false;
            if (name.Text == String.Empty || age.Text == String.Empty || id.Text == String.Empty || number.Text == String.Empty || address.Text == String.Empty || bonus.Text == String.Empty || workingHours.Text == String.Empty || salary.Text == String.Empty || shift.Text == String.Empty)
            {
                error = true;
                errorMessage.ForeColor = System.Drawing.Color.Red;
                errorMessage.Text = "Fill All Inputs";
                return;
            }
                string str = "";
            if(female_button.Checked)
            {
                str = "female";
            }
            if (male_button.Checked)
            {
                str = "male";
            }
            if (!error)
            {
                errorMessage.ForeColor = System.Drawing.Color.Green;
                errorMessage.Text = "Manager Added Successfully!";
                DateTime d = DateTime.Now;
                Dashboard.allStaffMembers.Add(new Manager(name.Text.ToLower(), Convert.ToInt32(age.Text), id.Text, number.Text, address.Text.ToLower(), shift.Text.ToLower(), str, Convert.ToDouble(bonus.Text), Convert.ToDouble(workingHours.Text), Convert.ToDouble(salary.Text), d));
            }

        }



        private void cancel_button_click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
