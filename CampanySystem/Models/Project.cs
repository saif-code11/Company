using System.ComponentModel.DataAnnotations.Schema;

namespace CampanySystem.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate   { get; set; }
        public decimal Budget { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public List<EmployeeProject> employeeProjects { get; set; } = new List<EmployeeProject>();

    }
}
