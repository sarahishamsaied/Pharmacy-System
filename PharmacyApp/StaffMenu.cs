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
    public partial class StaffMenu : Form
    {
        public StaffMenu()
        {
            InitializeComponent();
        }

        private void managerButton_click(object sender, EventArgs e)
        {
            AddManager m = new AddManager();
            m.ShowDialog();
        }

        private void cashierButton_Click(object sender, EventArgs e)
        {
            AddCashier a = new AddCashier();
            a.ShowDialog();
        }

        private void pharmacistButton_click(object sender, EventArgs e)
        {
            AddPharmacist p = new AddPharmacist();
            p.ShowDialog();
        }

        private void viewAllStaffButtonHandler(object sender, EventArgs e)
        {
            AllStaffMembers d = new AllStaffMembers();
            d.ShowDialog();
        }
    }
}
