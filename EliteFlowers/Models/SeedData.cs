using EliteFlowers.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System;
using System.Drawing;
using System.Net.NetworkInformation;


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
                    
                    FlowerType = "Rose",
                    Quantity = 3.00M,
                    Color = "Red",
                    Size = "Small",
                    Price = 20.00M,
            },
            new Flowers
            {
                FlowerType = "Sun Flower",
                Quantity = 2.00M,
                Color = "Yellow",
                Size = "Large",
                Price = 20.00M,
                    
            },
            new Flowers
            {
                FlowerType = "Tulip",
                Quantity = 5.00M,
                Color = "Purple",
                Size = "Small",
                Price = 10.00M,
                    
            },
            new Flowers
            {
                FlowerType = "Orchid",
                Quantity =1.00M,
                Color = "White",
                Size = "Medium",
                Price = 30.00M,
                    
            },
            new Flowers
            {
                FlowerType = "Marigold",
                Quantity = 2.00M,
                Color = "Yellow",
                Size = "Large",
                Price = 6.00M,

            },
            new Flowers
            {
                FlowerType = "Peony",
                Quantity = 2.00M,
                Color = "Pink",
                Size = "Large",
                Price = 10.00M,

            },
            new Flowers
            {       
                FlowerType = "Dahlia",
                Quantity = 1.00M,
                Color = "White",
                Size = "Medium",
                Price = 20.00M,

            },
            new Flowers
            {        
                FlowerType = "Lavender",
                Quantity = 7.00M,
                Color = "Purple",
                Size = "Small",
                Price = 45.00M,

            },
            new Flowers
            {        
                FlowerType = "Azalea",
                Quantity = 2.00M,
                Color = "Pink",
                Size = "Large",
                Price = 25.00M,

            },
            new Flowers
            {
                FlowerType = "Carnation",
                Quantity = 9.00M,
                Color = "Red",
                Size = "Small",
                Price = 99.00M,

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


