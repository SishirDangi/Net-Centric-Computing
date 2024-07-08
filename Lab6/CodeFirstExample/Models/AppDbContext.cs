// Models/AppDbContext.cs
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-9TJNSEL\\SQLEXPRESS;Database=CodeFirstDb;Integrated Security=True;TrustServerCertificate=True;");
    }
}
