using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Input array
        int[] numbers = { 1, 2, 3, 4, 5 };

        // LINQ query to find the numbers and their squares
        var numbersAndSquares = from num in numbers
                                select new { Number = num, Square = num * num };

        // Output the numbers and their squares
        Console.WriteLine("Number\tSquare");
        foreach (var item in numbersAndSquares)
        {
            Console.WriteLine($"{item.Number}\t{item.Square}");
        }
    }
}
