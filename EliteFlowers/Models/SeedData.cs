using EliteFlowers.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
using System.Drawing;


namespace EliteFlowers.Models;
public class SeedData : Controller
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new EliteFlowersContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<EliteFlowersContext>>()))
        {
            // Look for any movies.
            if (context.Flowers.Any())
            {
                return;   // DB has been seeded
            }
            context.Flowers.AddRange(
            new Flowers
            {
                    FlowerType = "When Harry Met Sally",
                    Quantity = 5.55M,
                    Color = "Romantic Comedy",
                    Size = "R",
                    Price = 7.99M,
            },
                new Flowers
                {
                    FlowerType = "Ghostbusters ",
                    Quantity = 5.55M,
                    Color = "Comedy",
                    Size = "R",
                    Price = 8.99M,
                    
                },
                new Flowers
                {
                    FlowerType = "Ghostbusters 2",
                    Quantity = 5.55M,
                    Color = "Comedy",
                    Size = "R",
                    Price = 9.99M,
                    
                },
                new Flowers
                {
                    FlowerType = "Rio Bravo",
                    Quantity = 5.55M,
                    Color = "Western",
                    Size = "R",
                    Price = 3.99M,
                    
                }
            );
            context.SaveChanges();
            if (context.Flowers.Any())
            {
                return;
            }
        }
    }
}


