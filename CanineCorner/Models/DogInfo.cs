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

        public string User { get; set; }

        [Required(ErrorMessage = "Please enter your dog's name")]
        public string DogName { get; set; }

        [Required(ErrorMessage = "Please enter your dog's breed")]
        public string Breed { get; set; }

        [Required(ErrorMessage = "Please enter your dog's weight")]
        [Range(0, double.MaxValue,ErrorMessage ="Enter a positive weight")]
        public int Weight { get; set; }

        [Required(ErrorMessage = "Please enter your dog's height")]
        [Range(0,double.MaxValue, ErrorMessage = "Enter a positive height")]
        public int Height { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DoB { get; set; }

        [DataType(DataType.Date)]
        public DateTime TodayDate { get; set; }
    }
}
