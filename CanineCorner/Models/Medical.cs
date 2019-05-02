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

        [Required(ErrorMessage = "Please enter your dog's name")]
        public string DogName { get; set; }

        [Required(ErrorMessage = "Please enter the medication's name")]
        public string MedName { get; set; }

        [Required(ErrorMessage = "Please enter how often the medication is needed")]
        public string Periodicity { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastDateGiven { get; set; }
    }
}
