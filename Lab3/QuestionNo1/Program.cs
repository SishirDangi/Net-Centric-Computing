using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Sample data: Student class with Name and Marks properties
        List<Student> students = new List<Student>()
        {
            new Student { Name = "Amir", Marks = 78 },
            new Student { Name = "Pawan", Marks = 85 },
            new Student { Name = "Bibek", Marks = 90 },
            new Student { Name = "Abhishek", Marks = 82 },
            new Student { Name = "Sabin", Marks = 65 }
        };

        // LINQ query to find students with marks greater than 80
        var studentsWithHighMarks = from student in students
                                    where student.Marks > 80
                                    select student;

        // Count the number of students with marks greater than 80
        int count = studentsWithHighMarks.Count();

        Console.WriteLine("Number of students with marks greater than 80: " + count);
        Console.WriteLine("Students with marks greater than 80:");
        foreach (var student in studentsWithHighMarks)
        {
            Console.WriteLine($"{student.Name}: {student.Marks}");
        }
    }
}

class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }
}
