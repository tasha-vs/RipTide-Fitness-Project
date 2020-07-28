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
    public partial class Manage_Classes : Form
    {

        List<FitnessClass> AvailableClasses = new List<FitnessClass>();

        public void DeleteClass(string className)
        {
            //clearing items in list box
            lstbxClasses.Items.Clear();
            //looping through available class list
            for (int i = 0; i < AvailableClasses.Count - 1; i++)
            {
                //checking if the name of the class matches the name of the parsed class name
                if (AvailableClasses[i].Name == className)
                {
                    //deleting class
                    AvailableClasses.Remove(AvailableClasses[i]);
                }
            }
            //looping through each class in available class list 
            foreach (var item in AvailableClasses)
            {
                //adding the classes back into the list box (to leave the deleted class out)
                lstbxClasses.Items.Add(item.Name);
            }

            //had to add this as since my classes are hard-coded, a deleted class will be 
            //added back into available classes when the form is restarted
            MessageBox.Show("Class Successfully Deleted", "Completed");
            MessageBox.Show("Please be aware, since the class list is hardcoded into the program, this action has only temporarily removed " +
                "the class. In order for it to be removed completely, the code in the program must be changed.", "Alert");
        }

        private void DisplayClasses()
        {
            //getting our class list and storing it in our list of fitness cass objects
            AvailableClasses = Program.GetClassList();
            //looping through our available classes list
            foreach (var item in AvailableClasses)
            {
                //displaying item in our list box
                lstbxClasses.Items.Add(item.Name);
            }
        }

        public Manage_Classes()
        {
            InitializeComponent();
            DisplayClasses();
        }

        private void lstbxClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            //grabbing the selected index num
            int index = lstbxClasses.SelectedIndex;

            //storing class information in relevant txt boxes
            txtbxName.Text = AvailableClasses[index].Name;
            txtbxDuration.Text = AvailableClasses[index].Duration.ToString();
            txtbxLevel.Text = AvailableClasses[index].Level;
            //grabbing unique child class variable (e.g fitness level req. for cardio classes)
            string UniqueClassVariable = AvailableClasses[index].VariableToDisplay();

            //determining what label to display depending on the class object type 
            //(this is the label for the above mentioned child class variable)
            if (AvailableClasses[index].GetType() == typeof(Strength_Class))
            {
                lblVariable.Text = "Weight Type:";
            }
            else if (AvailableClasses[index].GetType() == typeof(Cardio_Class))
            {
                lblVariable.Text = "Fitness Level:";
            }
            else if (AvailableClasses[index].GetType() == typeof(Balance_Class))
            {
                lblVariable.Text = "Type:";
            }
            else { lblVariable.Text = ""; }

            txtbxClassVar.Text = UniqueClassVariable;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //exit form
            lstbxClasses.Items.Clear();
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //go back to admin home
            this.Hide();
            //creating a new instance of the admin home form
            Admin_Home admHome = new Admin_Home();
            //loading that form
            admHome.ShowDialog();
            //closing this form
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (only one) class is selected
            if (lstbxClasses.SelectedItems.Count == 1)
            {
                //setting variables for our slected items index and name
                int indexer = lstbxClasses.SelectedIndex;
                string name = lstbxClasses.Items[indexer].ToString();
                //if the name is Zen
                if (name == "Zen")
                {
                    //do not delete this class
                    //alert user
                    MessageBox.Show("This is a core class that cannot be deleted..", "Error");
                }
                else
                {
                    //delete class
                    DeleteClass(name);
                }
            }
            else
            {
                //alert user
                MessageBox.Show("Please ensure one, and only one class has been selected", "Error");
            }
        }
    }
}
