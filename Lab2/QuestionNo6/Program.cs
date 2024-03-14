using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Array of names
        string[] names = { "Ram", "Shyam", "Hari", "Bikash", "Mahesh" };

        // Sorting names using LINQ
        var sortedNames = names.OrderBy(name => name);

        // Print sorted names
        Console.WriteLine("Sorted Names:");
        foreach (var name in sortedNames)
        {
            Console.WriteLine(name);
        }

        Console.ReadLine();
    }
}
