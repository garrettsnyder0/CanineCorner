using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanineCorner.Models
{
    public class BreedInfo
    {
        public int ID { get; set; }

        public string Breed { get; set; }

        public int adaptability { get; set; }

        public int friendliness { get; set; }

        public int health { get; set; }

        public int grooming { get; set; }

        public int training { get; set; }

        public int exercise { get; set; }
    }
}
