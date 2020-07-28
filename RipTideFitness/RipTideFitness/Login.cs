using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RipTideFitness
{
    public partial class Login : Form
    {
        public Login()
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
            //if user has not entered any data
            if (txtbxUsername.Text == "" || txtbxPassword.Text == "")
            {
                //alert user
                MessageBox.Show("An error occured... Please enter a username and a password", "Error");
            }
            else
            {
                //creating a connection to our riptide database
                SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Tasha\\source\\repos\\RipTideFitness\\RipTideFitness\\RipTideDB.mdf;Integrated Security=True");
                //SqlCommand cmd = new SqlCommand("SELECT Password FROM Member WHERE Username = '" + txtbxUsername.Text + "'", con);

                //creating our query to grab a member from the database that matches the user input username and password
                string query = "Select * from Member where Username = '" + txtbxUsername.Text.Trim() + "' and Password =  '" + txtbxPassword.Text.Trim() + "'";
                //creating a new sqldataadapter with out new query and connection as parameters
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(query, con);

                try
                {
                    //creating a new datatable
                    DataTable dataTable = new DataTable();
                    //filling the data table with the data grabbed from our sql adapter
                    mySqlDataAdapter.Fill(dataTable);

                    //if there is data in the table
                    if (dataTable.Rows.Count == 1)
                    {
                        //login
                        //go to member home page
                        this.Hide();
                        Logged_In_Home login_home = new Logged_In_Home();
                        login_home.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        //alerting user and resetting txt boxes
                        MessageBox.Show("An error occured... Member not found", "Error");
                        txtbxPassword.Text = "";
                        txtbxUsername.Text = "";
                    }
                }
                catch
                {
                    // alerting the user the reg failed and resetting text boxes
                    MessageBox.Show("An error occured... Please try again", "Error");
                    txtbxPassword.Text = "";
                    txtbxUsername.Text = "";
                }
            }
        }
    }
}
