using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class AllStaffMembers : Form
    {
        public AllStaffMembers()
        {
            InitializeComponent();
            staffTable.DataSource = Dashboard.allStaffMembers;
        }

        private void AllStaffMembers_Load(object sender, EventArgs e)
        {

        }
    }
}
