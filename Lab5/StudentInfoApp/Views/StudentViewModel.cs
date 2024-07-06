using System.ComponentModel.DataAnnotations;

namespace StudentInfoApp.ViewModels
{
    public class StudentViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Course is required")]
        public string? Course { get; set; }

        [Required(ErrorMessage = "Semester is required")]
        [Range(1, 8, ErrorMessage = "Semester must be between 1 and 8")]
        public int Semester { get; set; }

        public bool IsValid { get; set; }
    }
}
