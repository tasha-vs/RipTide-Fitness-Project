using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipTideFitness
{
    class Balance_Class : FitnessClass
    {
        public string Type { get; set; }

        public Balance_Class(string type)
        {
            Type = type;
        }

        public Balance_Class()
        {
        }

        public override string VariableToDisplay()
        {
            return Type.ToString();
        }
    }
}
