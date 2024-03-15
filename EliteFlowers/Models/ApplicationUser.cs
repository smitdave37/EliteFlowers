using Microsoft.AspNetCore.Identity;

namespace EliteFlowers.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = null!;
    }
}
