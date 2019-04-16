using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanineCorner.Models
{
    public class Training
    {
        public int ID { get; set; }
        public int Overall { get; set; }
        public int Easiness { get; set; }
        public int Intelligence { get; set; }
        public int Mouthiness { get; set; }
        public int PreyDrive { get; set; }
        public int Barking { get; set; }
        public int Wanderlust { get; set; }
    }
}
