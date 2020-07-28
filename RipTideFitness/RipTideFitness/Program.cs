using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RipTideFitness
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        //creating a new string list to store our equipment details
        public static List<string> equipment = new List<string>();

        //resetting our list
        public static void ClearEquipmentList()
        {
            //looping through each item in list
            foreach (string item in equipment.ToList())
            {
                //removing it
                equipment.Remove(item);
            }
        }

        public static List<string> GetEquipmentList()
        {

            //setting our relative path
            var path = @"./equipment_list.txt";
            //reading all lines from our file
            string[] lines = File.ReadAllLines(path);
            //looping through file
            foreach (string line in lines)
            {
                //adding line to our equipment list
                equipment.Add(line);
            }
            //returning the equipment list
            return equipment;
        }

        public static void DeleteEquipment(int index)
        {
            //storing our relative path 
            var path = @"./equipment_list.txt";
            //grabing the name of the equipment to delete
            string itemToDelete = equipment[index];
            //reading all the lines within the txt file
            var Lines = File.ReadAllLines(path);
            //only storing a line if it does not contain the equipment name the user wishes to delete
            var newLines = Lines.Where(line => !(line.Contains(itemToDelete)));
            //overwriting our file with our new lines (leaving out our deleted line)
            File.WriteAllLines(path, newLines);
        }

        public static void CreateNewEquipment(string name)
        {
            //setting our relative path 
            var path = @"./equipment_list.txt";
            //appending our new equipment item in a new line
            using (StreamWriter sw = File.AppendText(path))
            {
                //writing the new equipment name
                sw.WriteLine(name);
            }
        }

        public static List<FitnessClass> GetClassList()
        {
            //creating and adding our classes 

            Strength_Class StrengthClass1 = new Strength_Class
            {
                Name = "Pump",
                Duration = 60,
                Level = "Intermediate",
                WeightType = "Barbells, Bar"
            };

            Strength_Class StrengthClass2 = new Strength_Class()
            {
                Name = "Combat",
                Duration = 45,
                Level = "Beginner",
                WeightType = "Body Weight",
            };

            Cardio_Class CardioClass1 = new Cardio_Class
            {
                Name = "Attack",
                Duration = 60,
                Level = "Intermediate",
                FitnessLevelRequired = "High fitness Level Required"
            };

            Cardio_Class CardioClass2 = new Cardio_Class
            {
                Name = "Zumba",
                Duration = 45,
                Level = "Beginner",
                FitnessLevelRequired = "No fitness Level Required"
            };

            Balance_Class BalanceClass1 = new Balance_Class
            {
                Name = "Easy Yoga",
                Duration = 30,
                Level = "Beginner",
                Type = "Yoga"
            };

            Balance_Class BalanceClass2 = new Balance_Class
            {
                Name = "Master Pilates",
                Duration = 90,
                Level = "Advanced",
                Type = "Pilates"
            };

            Balance_Class BalanceClass3 = new Balance_Class
            {
                Name = "Zen",
                Duration = 60,
                Level = "Intermediate",
                Type = "Thai Chi"
            };

            if (AvailableClasses.Count == 0)
            {
                AvailableClasses.Add(StrengthClass1);
                AvailableClasses.Add(StrengthClass2);
                AvailableClasses.Add(CardioClass1);
                AvailableClasses.Add(CardioClass2);
                AvailableClasses.Add(BalanceClass1);
                AvailableClasses.Add(BalanceClass2);
                AvailableClasses.Add(BalanceClass3);
            }
            //returning our class list
            return AvailableClasses;
        }

        public static List<FitnessClass> AvailableClasses = new List<FitnessClass>(30);

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }


    }
}
