using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipTideFitness
{
    public class FitnessClass
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Level { get; set; }

        public FitnessClass(string name, int duration, string level)
        {
            Name = name;
            Duration = duration;
            Level = level;
        }

        public FitnessClass()
        {
        }

        public virtual string VariableToDisplay()
        {
            return "";
        }
    }
}
