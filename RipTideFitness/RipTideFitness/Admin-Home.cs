using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RipTideFitness
{
    public partial class Admin_Home : Form
    {
        public Admin_Home()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //exit
            Application.Exit();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            //Go to members mgmt
            this.Hide();
            Manage_StaffDB mgm_mem = new Manage_StaffDB();
            mgm_mem.ShowDialog();
            this.Close();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            //Go to staff mgmt
            this.Hide();
            ManageStaff mgm_staff = new ManageStaff();
            mgm_staff.ShowDialog();
            this.Close();
        }

        private void btnClasses_Click_1(object sender, EventArgs e)
        {
            //Go to class mgmt
            this.Hide();
            Manage_Classes mgm_classes = new Manage_Classes();
            mgm_classes.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Go to equipment mgmt
            this.Hide();
            Manage_Equipment mgm_equipment = new Manage_Equipment();
            mgm_equipment.ShowDialog();
            this.Close(); 
        }
    }
}
