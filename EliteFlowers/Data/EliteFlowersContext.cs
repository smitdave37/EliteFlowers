using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EliteFlowers.Models;

namespace EliteFlowers.Data
{
    public class EliteFlowersContext : DbContext
    {
        public EliteFlowersContext (DbContextOptions<EliteFlowersContext> options)
            : base(options)
        {
        }

        public DbSet<EliteFlowers.Models.Flowers> Flowers { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
