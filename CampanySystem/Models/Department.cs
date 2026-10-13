using System.ComponentModel.DataAnnotations;

namespace CampanySystem.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required , MaxLength(100)]
        public string Name { get; set; }
        [Required , MaxLength(100)]
        public string Location { get; set; }
        
        public List<Employee> employees { get; set; }   = new List<Employee>();
        public List<Project> Projects { get; set; }   = new List<Project>();
    }
}
