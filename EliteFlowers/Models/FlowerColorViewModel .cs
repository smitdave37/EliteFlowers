using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;


namespace EliteFlowers.Models;
public class FlowerColorViewModel
{
    public List<Flowers>? Flowers { get; set; }
    public SelectList? Colors { get; set; }
    public string? FlowerColor { get; set; }
    public string? SearchString { get; set; }
}