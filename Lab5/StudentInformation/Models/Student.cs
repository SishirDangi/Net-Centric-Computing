// Student.cs
using System.ComponentModel.DataAnnotations;

namespace StudentInformation.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Please enter student name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter course")]
        public string Course { get; set; }

        [Required(ErrorMessage = "Please enter semester")]
        [Range(1, int.MaxValue, ErrorMessage = "Semester must be a positive number")]
        public int Semester { get; set; }
    }
}
