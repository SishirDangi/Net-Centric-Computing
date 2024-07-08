// Program.cs
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new AppDbContext())
        {
            SeedData.Initialize(context);

            var products = context.Products.ToList();

            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.ProductId}, Name: {product.Name}, Price: {product.Price}");
            }
        }
    }
}
