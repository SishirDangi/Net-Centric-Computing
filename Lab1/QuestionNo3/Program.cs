using System;

class Program {
    static void Main(string[] args) {
        // Prompt the user to input the size of the array
        Console.Write("Enter the size of the array: ");
        int size = int.Parse(Console.ReadLine());

        // Create an array of the specified size
        int[] array = new int[size];

        // Prompt the user to input the elements of the array
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++) {
            Console.Write("Element {0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        // Display original array
        Console.WriteLine("\nOriginal array:");
        PrintArray(array);

        // Reverse the array
        ReverseArray(array);

        // Display reversed array
        Console.WriteLine("\nReversed array:");
        PrintArray(array);
    }

    // Method to reverse the elements of an array
    static void ReverseArray(int[] arr) {
        int start = 0;
        int end = arr.Length - 1;

        while (start < end) {
            // Swap elements at start and end indices
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            // Move towards the center of the array
            start++;
            end--;
        }
    }

    // Method to print the elements of an array
    static void PrintArray(int[] arr) {
        foreach (int num in arr) {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}
