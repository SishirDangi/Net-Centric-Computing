using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DatabaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new EmployeeDbContext())
            {
                // Ensure the database is created
                dbContext.Database.EnsureCreated();

                // Query the Employees table
                var employees = dbContext.Employees.ToList();

                // Display results
                Console.WriteLine("Employees:");
                foreach (var employee in employees)
                {
                    Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Age: {employee.Age}, Position: {employee.Position}");
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

    // Define your DbContext
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Replace 'YourConnectionString' with your actual SQL Server connection string
            optionsBuilder.UseSqlServer("Server=DESKTOP-9TJNSEL\\SQLEXPRESS;Database=EmployeeDB;Integrated Security=True;TrustServerCertificate=True;");
        }
    }

    // Define your Employee entity
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
    }
}
