using CampanySystem.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CampanySystem.Dtos
{
    public class EmpPrjectDtos
    {
        public int Id { get; set; }
        
        public int EmployeeId { get; set; }

        public int ProjectId { get; set; }

        public string AssignedRole { get; set; }
        public DateTime AssignedDate { get; set; }
    }
    public class EmpPrjectCreateDtos
    {

        public int EmployeeId { get; set; }

        public int ProjectId { get; set; }

        public string AssignedRole { get; set; }
        public DateTime AssignedDate { get; set; }
    }
}
