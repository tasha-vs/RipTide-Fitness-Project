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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //go back
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if username and password are correct
            if (txtbxUsername.Text.ToLower() == "admin" && txtbxPassword.Text.ToLower() == "admin")
            {
                //go to admin home
                this.Hide();
                Admin_Home aHome = new Admin_Home();
                aHome.ShowDialog();
                this.Close();
            }
            else if (txtbxUsername.Text == "" || txtbxPassword.Text == "")
            {
                //alert user
                MessageBox.Show("Please ensure both username and password contains data", "Error");
            }
            else
            {
                //alert user
                MessageBox.Show("Incorrect admin login", "Error");
            }

        }
    }
}
