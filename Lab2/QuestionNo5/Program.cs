using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a dictionary to store CustomerId and CustomerName
        Dictionary<int, string> customers = new Dictionary<int, string>();

        // Add customer information to the dictionary
        customers.Add(1, "Hari");
        customers.Add(2, "Sita");
        customers.Add(3, "Gopal");
        customers.Add(4, "Purna");
        customers.Add(5, "Sarita");

        // Print CustomerId and CustomerName
        Console.WriteLine("CustomerId\tCustomerName");
        foreach (var customer in customers)
        {
            Console.WriteLine($"{customer.Key}\t\t{customer.Value}");
        }

        Console.ReadLine();
    }
}
