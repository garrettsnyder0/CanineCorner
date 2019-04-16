using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanineCorner.Models
{
    public class Exercise
    {
        public int ID { get; set; }
        public int Overall { get; set; }
        public int EnergyLevel { get; set; }
        public int Intensity { get; set; }
        public int ExerciseNeed { get; set; }
        public int Playfulness { get; set; }
    }
}
