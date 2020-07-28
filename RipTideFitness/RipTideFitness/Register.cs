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
    public partial class Register : Form
    {
        public Register()
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

        private void txtbxFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allowing user to enter letters, press backspace and have spaces
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtbAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allowing user to enter numbers and press backspace
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtbAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allowing user to enter letters, numbers, press backspace and have spaces
            if (!char.IsNumber(e.KeyChar) && (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar))))
            {
                e.Handled = true;
            }
        }

        private void txtbCardDetails_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allowing user to enter numbers and press backspace
            if (!char.IsNumber(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //creating a connection to our 'riptide' database
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Tasha\\source\\repos\\RipTideFitness\\RipTideFitness\\RipTideDB.mdf;Integrated Security=True");

            //checking that all required fields have data
            if (txtbxFullName.Text == "" || txtbAddress.Text == "" || txtbCardDetails.Text == "" || txtbUsername.Text ==  "" || txtbxPassword.Text == "")
            {
                MessageBox.Show("An error occured... Please ensure all registration fields contain data", "Error");
            }
            else
            {
                //creating a query to check if the username is already in use
                string usernameQuery = "Select * from Member where Username = '" + txtbUsername.Text.Trim() + "'";
                //creating a new adapter with out above query and connection
                SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(usernameQuery, con);
                //creating a new datatable
                DataTable dataTable = new DataTable();
                //filling the data table with the data grabbed from our sql adapter
                mySqlDataAdapter.Fill(dataTable);

                //if there is data in the table (ie the username is in use)
                if (dataTable.Rows.Count == 1)
                {
                    //alert the user
                    MessageBox.Show("Username is already in use, Please choose a differrent one", "Error");
                    txtbUsername.Text = "";
                }
                //if the username is available
                else
                {
                    //creating a command that inserts the user entered registration data into the member table
                    SqlCommand cmd = new SqlCommand("INSERT INTO Member(FullName, Age, Address, CardDetails, Username, Password) values('" + txtbxFullName.Text + "', '" + txtbAge.Text + "','" + txtbAddress.Text + "','" + txtbCardDetails.Text + "','" + txtbUsername.Text + "', '" + txtbxPassword.Text + "')", con);
                    //opening our database connection
                    con.Open();

                    try
                    {
                        //executing our query
                        int i = cmd.ExecuteNonQuery();
                        if (i != 0)
                        {
                            MessageBox.Show("Registration Successful");
                            //go to login page
                            this.Hide();
                            Login login = new Login();
                            login.ShowDialog();
                            this.Close();
                        }
                    }
                    //if an error occurs
                    catch
                    {
                        //alerting the user the reg failed
                        MessageBox.Show("An error occured... Please try again", "Error");
                        //clears all text boxes
                        txtbAddress.Text = "";
                        txtbAge.Text = "";
                        txtbCardDetails.Text = "";
                        txtbxFullName.Text = "";
                        txtbUsername.Text = "";
                        txtbxPassword.Text = "";
                    }
                }
            }
        }

        private void txtbxPassword_TextChanged(object sender, EventArgs e)
        {
            // Set to no text.
            txtbxPassword.Text = "";
            // The password character is an asterisk.
            txtbxPassword.PasswordChar = '*';
        }
    }
}
