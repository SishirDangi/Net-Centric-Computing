using System;

namespace QuestionNo1
{
    class TwoDigitAdder
    {
        private int digit1;
        private int digit2;

        // Constructor to initialize the digits
        public TwoDigitAdder(int num1, int num2)
        {
            digit1 = num1;
            digit2 = num2;
        }

        // Method to add the digits
        public int AddDigits()
        {
            return digit1 + digit2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Input two digits from the user
            Console.Write("Enter first digit: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second digit: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Create an instance of TwoDigitAdder class with the entered digits
            TwoDigitAdder adder = new TwoDigitAdder(num1, num2);

            // Call AddDigits method to perform addition and display the result
            int result = adder.AddDigits();
            Console.WriteLine("Sum of the digits: " + result);
            Console.ReadLine();
        }
    }
}

