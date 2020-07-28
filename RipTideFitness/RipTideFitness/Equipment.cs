using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipTideFitness
{
    /*
     * PLEASE NOTE:this code was taken from the indexersGenerics lecture slides (page 4)
     * I have modified it ever so slightly to better suit my assignment, however i did not quite manage to get it to work 
     * in the way that i had hoped. 
     */
    class Equipment
    {
        private string[] EquipmentList = new string[size];
        static public int size = 30;

        //setting our default constructor to set all items in list to our chosen string
        public Equipment()
        {
            for (int i = 0; i < size; i++)
            {
                EquipmentList[i] = "Space Empty";
            }
        }

        //setting our getters and setters for the index
        public string this[int index]
        {
            get
            {
                //checking to see if there is a value set
                string tmp;
                if (index >= 0 && index <= size)
                {
                    //if index is within range set our temp string to the index of our item 
                    tmp = EquipmentList[index];
                }
                else
                {
                    tmp = "";
                }
                //return our string containing the index num (or "")
                return tmp;
            }
            set
            {
                //setting value
                if (index >= 0 && index <= size - 1)
                {
                    EquipmentList[index] = value;
                }
            }
        }
    }
}
