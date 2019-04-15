using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CanineCorner.Models
{
    public class DogInfo
    {
        public int ID { get; set; }

        public int User { get; set; }

        public string DogName { get; set; }

        public string Breed { get; set; }

        public int Weight { get; set; }

        public int Height { get; set; }

        [DataType(DataType.Date)]
        public DateTime DoB { get; set; }

        [DataType(DataType.Date)]
        public DateTime TodayDate { get; set; }
    }
}
