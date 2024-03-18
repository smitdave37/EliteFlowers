using EliteFlowers.Models;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.Diagnostics;

namespace EliteFlowers.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any ApplcationUser.
            if (context.ApplicationUser.Any())
            {
                return;   // DB has been seeded
            }

            var ApplicationUser = new ApplicationUser[]
            {
            new ApplicationUser{Firstname="Smit",Lastname="Dave",Id="7c316991-3e2a-42a3-9e4e-051292e8ba6f",UserName="admin@gmail.com",Email="admin@gmail.com",PasswordHash="AQAAAAIAAYagAAAAEL+QrjcEcfpG70IUHbkoVCGofZDVTqQF75stGWHXe0NUweSDhVFu3yJL5okx96+BQw=="},
            new ApplicationUser{Firstname="Amandeep",Lastname="Kaur",Id="c58b5745-de90-49cc-9bfe-60c0b85895eb",UserName="guest1@gmail.com",Email="guest1@gmail.com",PasswordHash="AQAAAAIAAYagAAAAEMvSReBg4bFpmRgRZOQi07KuTGl0vOyRYUasOHtLdnfEOuZ8VNtVuQI0Xa7IrlgJlQ=="},
            new ApplicationUser{Firstname="Kejan",Lastname="Jada", Id ="dcdd0073-b290-42cd-bf57-a0a7cc30992a",UserName="guest@gmail.com",Email="guest@gmail.com",PasswordHash="AQAAAAIAAYagAAAAEIkB49p/opu63Yg1FWdmNil8n7I0bnNDKFlipWcCBANj5dYZ/V1Vyepsurbu0N+hoQ=="},


            };
           
            context.SaveChanges();
        }
    }
}



