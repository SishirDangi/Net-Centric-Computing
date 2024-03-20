using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // List of cities
        List<string> cities = new List<string> { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEWDELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

        // Ask user to input start and end characters
        Console.WriteLine("Enter the start character:");
        char startChar = Console.ReadLine()[0];

        Console.WriteLine("Enter the end character:");
        char endChar = Console.ReadLine()[0];

        // Find strings that start and end with the specified characters
        List<string> matchedCities = FindCities(cities, startChar, endChar);

        // Print the matched cities or "Not found" message
        if (matchedCities.Count > 0)
        {
            Console.WriteLine($"Cities that start with '{startChar}' and end with '{endChar}':");
            foreach (string city in matchedCities)
            {
                Console.WriteLine(city);
            }
        }
        else
        {
            Console.WriteLine("No cities found that start with the specified character and end with the specified character.");
        }
    }

    // Function to find cities that start and end with specific characters
    static List<string> FindCities(List<string> cities, char startChar, char endChar)
    {
        List<string> matchedCities = new List<string>();

        foreach (string city in cities)
        {
            if (city.Length > 0 && city[0] == startChar && city[city.Length - 1] == endChar)
            {
                matchedCities.Add(city);
            }
        }

        return matchedCities;
    }
}
