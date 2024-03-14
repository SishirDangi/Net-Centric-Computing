using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a generic list to store numbers
        List<int> numbers = new List<int>();

        // Add numbers from 1 to 10 to the list
        for (int i = 1; i <= 10; i++)
        {
            numbers.Add(i);
        }

        // Print the numbers in the list
        Console.WriteLine("Numbers from 1 to 10:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.ReadLine();
    }
}
