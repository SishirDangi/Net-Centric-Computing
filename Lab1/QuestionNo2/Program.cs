using System;

class Student
{
    // Automatic properties for Student ID and Name
    public int StudentId { get; set; }
    public string Name { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Student class
        Student student = new Student();

        // Set values for student ID and name using automatic properties
        student.StudentId = 211811;
        student.Name = "Sishir Dangi";

        // Display student ID and name
        Console.WriteLine("Student ID: " + student.StudentId);
        Console.WriteLine("Name: " + student.Name);
        Console.ReadLine();
    }
}
