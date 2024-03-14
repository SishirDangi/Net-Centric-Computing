using System;

namespace DigitAdder
{
    // Define a delegate for adding two digits
    public delegate int Adder(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the delegate with a method
            Adder adder = AddTwoDigits;

            // Prompt the user to enter two digits
            Console.WriteLine("Enter the first digit:");
            int firstDigit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second digit:");
            int secondDigit = Convert.ToInt32(Console.ReadLine());

            // Call the delegate to add the two digits
            int sum = adder(firstDigit, secondDigit);

            // Display the result
            Console.WriteLine($"The sum of {firstDigit} and {secondDigit} is: {sum}");

            Console.ReadLine();
        }

        // Method to add two digits
        static int AddTwoDigits(int a, int b)
        {
            return a + b;
        }
    }
}
