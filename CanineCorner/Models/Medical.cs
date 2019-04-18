using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CanineCorner.Models
{
    public class Medical
    {
        public int ID { get; set; }

        public string User { get; set; }

        public string DogName { get; set; }

        public string MedName { get; set; }

        public string Periodicity { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastDateGiven { get; set; }
    }
}
