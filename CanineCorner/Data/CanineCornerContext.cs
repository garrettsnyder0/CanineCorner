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
    }
}
