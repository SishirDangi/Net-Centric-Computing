﻿using System;

namespace ArithmeticOperations
{
    class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            double num1, num2;
            Console.WriteLine("Enter two numbers:");
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Addition: {calculator.Add(num1, num2)}");
            Console.WriteLine($"Subtraction: {calculator.Subtract(num1, num2)}");
            Console.WriteLine($"Multiplication: {calculator.Multiply(num1, num2)}");
            try
            {
                Console.WriteLine($"Division: {calculator.Divide(num1, num2)}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
