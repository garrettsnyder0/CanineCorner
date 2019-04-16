using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CanineCorner.Models
{
    public class FullBreedStats
    {
        public string Breed                 { get; set; }
        public Adaptibility Adaptibility    { get; set; }
        public Exercise Exercise            { get; set; }
        public Friendliness Friendliness    { get; set; }
        public Grooming Grooming            { get; set; }
        public Health Health                { get; set; }
        public Training Training            { get; set; }
    }
}
