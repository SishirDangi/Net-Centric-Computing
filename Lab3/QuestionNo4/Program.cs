using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        // Dictionary to store characters and their frequencies
        Dictionary<char, int> charFrequencies = new Dictionary<char, int>();

        // Count frequencies of characters
        foreach (char c in input)
        {
            if (charFrequencies.ContainsKey(c))
            {
                charFrequencies[c]++;
            }
            else
            {
                charFrequencies[c] = 1;
            }
        }

        // Display characters and their frequencies
        Console.WriteLine("Character\tFrequency");
        foreach (var pair in charFrequencies.OrderBy(p => p.Key))
        {
            Console.WriteLine($"{pair.Key}\t\t{pair.Value}");
        }
    }
}
