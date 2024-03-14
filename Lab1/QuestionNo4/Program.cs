using System;

class Student
{
    private string[] names;

    // Constructor to initialize the names array
    public Student(int size)
    {
        names = new string[size];
    }

    // Indexer to access and modify names array
    public string this[int index]
    {
        get
        {
            // Check if index is within valid range
            if (index >= 0 && index < names.Length)
            {
                return names[index];
            }
            else
            {
                return "Invalid Index";
            }
        }
        set
        {
            // Check if index is within valid range
            if (index >= 0 && index < names.Length)
            {
                names[index] = value;
            }
            else
            {
                Console.WriteLine("Invalid Index");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Student class with size 5
        Student students = new Student(5);

        // Store names using indexer
        students[0] = "Ram";
        students[1] = "Sita";
        students[2] = "Hari";
        students[3] = "Shyam";
        students[4] = "Gita";

        // Retrieve and display names using indexer
        Console.WriteLine("Names of students:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Student {i + 1}: {students[i]}");
            Console.ReadLine();
        }
    }
}
