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
    public partial class Manage_StaffDB : Form
    {
        private void RefreshData()
        {
            //updating/refreshing database view and list so that once the edit has been saved, the db view will reflect it
            datagridDB.Update();
            datagridDB.Refresh();
            listBox1.ClearSelected();
            listBox1.Refresh();
            datagridDB.Visible = false;
            datagridDB.Visible = true;
        }

        private void DeleteMember()
        {
            //connecting to our db
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Tasha\\source\\repos\\RipTideFitness\\RipTideFitness\\RipTideDB.mdf;Integrated Security=True");
            //creating our delete query
            string queryDelete = "DELETE FROM Member WHERE MemberID = '" + txtbxHiddenID.Text + "'";
            //opening our db connection
            con.Open();

            //creating and initializing our command to the query and our db connection
            var command = new SqlCommand(queryDelete, con);
            //using this to check if the query was executed correctly
            int i = command.ExecuteNonQuery();

            //if query was successful
            if (i != 0)
            {
                MessageBox.Show("Member Successfully Deleted", "Success");
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

            //alerting user about restarting the app in order to view changes
            DialogResult result = MessageBox.Show("In order for the changes to be displayed, the application must be quit, then restarted. Would you like to quit now?", "Alert", MessageBoxButtons.YesNo);
            //if user selects yes
            if (result == DialogResult.Yes)
            {
                //exit application
                Application.Exit();
            }
        }

        public Manage_StaffDB()
        {
            InitializeComponent();
            //PopulateMemberDetails();
        }

        private void Manage_Members_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ripTideDBDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.ripTideDBDataSet.Member);
            //hide db and our hidden txtbx (only use this txtbox to delete member, so it does not need to be seen by user as they 
            //can see the member id in the list box)
            datagridDB.Visible = false;
            txtbxHiddenID.Visible = false;
        }

        private void txtbxUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allowing admin to enter numbers and press backspace
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
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

        private void txtbxCardDetails_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allowing admin to enter numbers and press backspace
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnViewDB_Click(object sender, EventArgs e)
        {
            //show db 
            datagridDB.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //save button
            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //calling delete method
            DeleteMember();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //back home
            this.Hide();
            Admin_Home adminHome = new Admin_Home();
            adminHome.ShowDialog();
            this.Close();
        }
    }
}
