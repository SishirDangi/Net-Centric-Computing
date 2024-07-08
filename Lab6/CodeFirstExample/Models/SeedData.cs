// Models/SeedData.cs
using System.Linq;

public class SeedData
{
    public static void Initialize(AppDbContext context)
    {
        if (!context.Products.Any())
        {
            context.Products.AddRange(
                new Product { Name = "Product1", Price = 10.0m },
                new Product { Name = "Product2", Price = 20.0m }
            );

            context.SaveChanges();
        }
    }
}
