using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanineCorner.Models
{
    public class Location
    {
        public int ID { get; set; }

        public string LocName { get; set; }

        public string LocType { get; set; }

        public int ZipCode { get; set; }

        public int Rating { get; set; }
    }
}
