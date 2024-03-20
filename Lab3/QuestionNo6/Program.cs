using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
}

class City
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Country { get; set; }
}

class Program
{
    static void Main()
    {
        // Sample data for persons
        List<Person> persons = new List<Person>
        {
            new Person { Id = 1, Name = "Sishir", City = "Kathmandu" },
            new Person { Id = 2, Name = "Suraj", City = "Mumbai" },
            new Person { Id = 3, Name = "Bob", City = "New York" }
        };

        // Sample data for cities
        List<City> cities = new List<City>
        {
            new City { Id = 1, Name = "Kathmandu", Country = "Nepal" },
            new City { Id = 2, Name = "Mumbai", Country = "India" },
            new City { Id = 3, Name = "New York", Country = "USA" }
        };

        // Joining persons and cities based on the city name
        var query = from person in persons
                    join city in cities on person.City equals city.Name
                    select new { person.Name, person.City, city.Country };

        // Displaying the joined data
        foreach (var item in query)
        {
            Console.WriteLine($"Name: {item.Name}, City: {item.City}, Country: {item.Country}");
        }
    }
}
