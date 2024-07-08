// Models/Product.cs
using System.ComponentModel.DataAnnotations;

public class Product
{
    public int ProductId { get; set; }
   
    public required string Name { get; set; }
    
    public decimal Price { get; set; }
}
