using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipTideFitness
{
    class Cardio_Class : FitnessClass
    {
        public string FitnessLevelRequired { get; set; }

        public Cardio_Class(string fitnessLevelRequired)
        {
            FitnessLevelRequired = fitnessLevelRequired;
        }

        public Cardio_Class()
        {
        }

        public override string VariableToDisplay()
        {
            return FitnessLevelRequired.ToString();
        }
    }
}
