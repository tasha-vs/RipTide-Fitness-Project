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
    public partial class Logged_In_Home : Form
    {
        private void DisplayClasses()
        {
            //creating a list for our classes
            List<FitnessClass> AvailableClasses = new List<FitnessClass>();
            //getting our class list and storing it in our list of fitness cass objects
            AvailableClasses = Program.GetClassList();
            //looping through our available classes list
            foreach (var item in AvailableClasses)
            {
                //displaying item in our list box
                lstbxClasses.Items.Add(item.Name);
            }
        }

        private void DisplayEquipment()
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

        public Logged_In_Home()
        {
            InitializeComponent();
            DisplayEquipment();
            DisplayClasses();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //exit
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //login
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }
    }
}
