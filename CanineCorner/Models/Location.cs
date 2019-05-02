using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CanineCorner.Models
{
    public class Location
    {
        public int ID { get; set; }

        public string LocName { get; set; }

        public string LocType { get; set; }

        public int ZipCode { get; set; }

        [Range(0,5)]
        public int Rating { get; set; }
    }
}
