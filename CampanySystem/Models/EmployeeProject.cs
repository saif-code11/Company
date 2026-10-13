using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CampanySystem.Models
{
    [Index(nameof(EmployeeId) , nameof(ProjectId) , IsUnique = true)]
    public class EmployeeProject
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Employee")]

        public int EmployeeId { get; set; }
        [ForeignKey("Project")]

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        [Required , MaxLength(50)]
        public string AssignedRole { get; set; }
        [Required]
        public DateTime AssignedDate { get; set; }
        public Employee Employee { get; set; }
    }
}
