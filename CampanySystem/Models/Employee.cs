using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CampanySystem.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required , MaxLength(150)]
        public string Name { get; set; }
        [Required, EmailAddress]

        public string Email { get; set; }
        [Required]
        public DateTime HireDate { get; set; }
        [Required, Range(3000, 100000)]

        public decimal Salary { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<EmployeeProject> employeeProjects { get; set; } = new List<EmployeeProject>();  
    }
}
