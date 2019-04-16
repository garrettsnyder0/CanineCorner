using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CanineCorner.Models;

namespace CanineCorner.Models
{
    public class CanineCornerContext : DbContext
    {
        public CanineCornerContext (DbContextOptions<CanineCornerContext> options)
            : base(options)
        {
        }

        public DbSet<CanineCorner.Models.DogInfo> DogInfo { get; set; }

        public DbSet<CanineCorner.Models.Medical> Medical { get; set; }

        public DbSet<CanineCorner.Models.Location> Location { get; set; }

        public DbSet<CanineCorner.Models.BreedInfo> BreedInfo { get; set; }

        public DbSet<CanineCorner.Models.Adaptibility> Adaptibility { get; set; }

        public DbSet<CanineCorner.Models.Exercise> Exercise { get; set; }

        public DbSet<CanineCorner.Models.Friendliness> Friendliness { get; set; }

        public DbSet<CanineCorner.Models.Health> Health { get; set; }

        public DbSet<CanineCorner.Models.Training> Training { get; set; }
    }
}
