using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EliteFlowers.Models;

namespace EliteFlowers.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EliteFlowers.Models.Flowers> Flowers { get; set; } = default!;
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
