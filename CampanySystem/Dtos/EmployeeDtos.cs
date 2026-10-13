using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CampanySystem.Dtos
{
    public class EmployeeDtos
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public DateTime HireDate { get; set; }

        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
    }
    public class EmployeeCreateDtos
    {
        public string Name { get; set; }

        public string Email { get; set; }
        public DateTime HireDate { get; set; }

        public decimal Salary { get; set; }
        public int DepartmentId { get; set; }
    }
}
