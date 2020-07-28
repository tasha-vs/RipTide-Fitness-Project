using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RipTideFitness
{
    public partial class ManageStaff : Form
    {
        private void RefreshData()
        {
            //updating/refreshing database view so that once the edit has been saved, the db view will reflect it
            dataGridDBStaff.Update();
            dataGridDBStaff.Refresh();
            listBoxStaffID.ClearSelected();
            listBoxStaffID.Refresh();
            dataGridDBStaff.Visible = false;
     
        }

        private void DeleteStaff()
        {
            //connecting to our db
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Tasha\\source\\repos\\RipTideFitness\\RipTideFitness\\RipTideDB.mdf;Integrated Security=True");
            //creating our delete query
            string queryDelete = "DELETE FROM Staff WHERE StaffId = '" + txtbxHiddenID.Text + "'";
            //opening our db connection
            con.Open();

            //creating and initializing our command to the query and our db connection
            var command = new SqlCommand(queryDelete, con);
            //using this to check if the query was executed correctly
            int i = command.ExecuteNonQuery();

            //if query was successful
            if (i != 0)
            {
                MessageBox.Show("Staff member Successfully Deleted", "Success");
            }
            //if query was not successful
            else
            {
                MessageBox.Show("An error occured... Please try again", "Error");
            }

            //refreshing our db data in form
            RefreshData();
            //closing our connection to the db
            con.Close();

            //alerting admin about restarting the app in order to view changes
            DialogResult result = MessageBox.Show("In order for the changes to be displayed, the application must be quit, then restarted. Would you like to quit now?", "Alert", MessageBoxButtons.YesNo);
            //if user selects yes
            if (result == DialogResult.Yes)
            {
                //exit application
                Application.Exit();
            }
        }


        public ManageStaff()
        {
            InitializeComponent();
        }

        private void ManageStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ripTideDBDataSet2.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.ripTideDBDataSet2.Staff);
            //hide db
            dataGridDBStaff.Visible = false;
            //hide txtbox (as it is only used for deleting staff)
            txtbxHiddenID.Visible = false;
        }

        private void txtbxFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allowing admin to enter letters, press backspace and have spaces
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtbxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allowing admin to enter numbers and press backspace
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtbxAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allowing admin to enter letters, numbers, press backspace and have spaces
            if (!char.IsNumber(e.KeyChar) && (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar))))
            {
                e.Handled = true;
            }
        }

        private void txtbxBankDetails_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allowing admin to enter numbers and press backspace
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtbxWage_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allowing admin to enter numbers and press backspace
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtbxJobTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allowing admin to enter letters, press backspace and have spaces
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnViewDB_Click(object sender, EventArgs e)
        {
            //show db 
            dataGridDBStaff.Visible = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //save button
            RefreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //back home
            this.Hide();
            Admin_Home adminHome = new Admin_Home();
            adminHome.ShowDialog();
            this.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //calling delete method
            DeleteStaff();
        }
    }
}
