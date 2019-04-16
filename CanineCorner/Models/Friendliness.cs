using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanineCorner.Models
{
    public class Friendliness
    {
        public int ID { get; set; }
        public int Overall { get; set; }
        public int WithFamily { get; set; }
        public int WithKids { get; set; }
        public int OtherDogs { get; set; }
        public int WithStrangers { get; set; }
    }
}
