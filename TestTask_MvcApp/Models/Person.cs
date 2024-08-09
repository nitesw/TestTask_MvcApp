using System.ComponentModel.DataAnnotations;

namespace TestTask_MvcApp.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Age must be between 0 and 100.")]
        public int Age { get; set; }
        public string? Profession { get; set; }
    }
}
