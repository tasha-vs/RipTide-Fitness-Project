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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //exit
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //login
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //register
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            this.Close();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            //admin
            this.Hide();
            AdminLogin aLogin = new AdminLogin();
            aLogin.ShowDialog();
            this.Close();
        }
    }
}
