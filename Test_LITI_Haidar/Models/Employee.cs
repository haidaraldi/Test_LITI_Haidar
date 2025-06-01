using System.ComponentModel.DataAnnotations;

namespace Test_LITI_Haidar.Models
{
    public class Employee
    {
        [Key]
        [Required]
        public required string Id { get; set; }

        public string? Name { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        public string? Position { get; set; }

        public double Salary { get; set; }

    }
}
