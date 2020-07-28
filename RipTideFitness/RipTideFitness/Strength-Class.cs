using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipTideFitness
{
    public class Strength_Class : FitnessClass
    {
        public string WeightType { get; set; }

        public Strength_Class(string weightType)
        {
            WeightType = weightType;
        }

        public Strength_Class()
        {
        }

        public override string VariableToDisplay()
        {
            return WeightType.ToString();
        }
    }
}
