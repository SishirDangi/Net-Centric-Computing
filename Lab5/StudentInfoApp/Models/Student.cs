using System.ComponentModel.DataAnnotations;

namespace StudentInfoApp.Models
{
    public class Student
    {

        [Required]
        public string Name { get; set; }

        [Required]
        public string Course { get; set; }

        [Required]
        public int Semester { get; set; }
    }
}