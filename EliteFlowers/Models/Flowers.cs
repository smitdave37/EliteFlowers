using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
namespace EliteFlowers.Models;

public class Flowers 
{
    public int Id { get; set; }
    public string? FlowerType { get; set; }

    public decimal Quantity { get; set; }

    public string? Color { get; set; }

    public decimal Price { get; set; }
    public string? Size { get; set; }

  
}
