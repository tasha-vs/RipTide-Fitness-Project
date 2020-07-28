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
    public partial class Manage_Equipment : Form
    {
        private void GetAndDisplayEquipment()
        {
            //clearing listbox
            lstbxEquipment.Items.Clear();
            //refresh list (otherwise it keeps adding to the list)
            Program.ClearEquipmentList();
            //creating new list of strings to store txt file lines
            List<string> equipment = new List<string>();
            //grabbing data from the txt file
            equipment = Program.GetEquipmentList();
            //creating a new indexer list
            Equipment equipmentList = new Equipment();

            //looping through our txt file data
            for (int i = 0; i < equipment.Count; i++)
            {
                //storing line data in our indexer array
                equipmentList[i] = equipment[i];
                //adding each array item to list
                lstbxEquipment.Items.Add(equipmentList[i]);
            }
        }

        public Manage_Equipment()
        {
            InitializeComponent();
            GetAndDisplayEquipment();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //go back to admin home
            this.Hide();
            Admin_Home admHome = new Admin_Home();
            admHome.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //exit form
            Application.Exit();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //checking if data has been entered into the txtbox
            if (txtbxName.Text != "")
            {
                //checking to see if equipment list is full (as defined in the equipment indexer class)
                if (lstbxEquipment.Items.Count < 30)
                {
                    try
                    {
                        //calling creat equipment method
                        Program.CreateNewEquipment(txtbxName.Text);
                        //refreshing list bx
                        GetAndDisplayEquipment();
                    }
                    catch 
                    {
                        //alerting user
                        MessageBox.Show("An error occured.. Please try again..", "Creation Failed");
                    }
                    
                }
                else
                {
                    //alert user
                    MessageBox.Show("Equipment is at capacity..", "Error");
                    txtbxName.Text = "";
                }
            }
            else
            {
                //alert user
                MessageBox.Show("Equipment name must not be null..", "Error");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //grabbing the index of the selected list box item
            int index = lstbxEquipment.SelectedIndex;
            //clearing the items within the list box
            lstbxEquipment.Items.Clear();
            //parsing index num to the delete method
            Program.DeleteEquipment(index);
            //clearing our equipment list
            Program.ClearEquipmentList();
            //reloading and displaying our equipment list in our list box
            GetAndDisplayEquipment();
        }

        private void txtbxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //only allowing user to enter letters, press backspace and have spaces
            if (!char.IsLetter(e.KeyChar) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
