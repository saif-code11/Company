using System.ComponentModel.DataAnnotations.Schema;

namespace CampanySystem.Dtos
{
    public class ProjectDtos
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Budget { get; set; }
        public int DepartmentId { get; set; }
    }
    public class ProjectCreateDtos
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Budget { get; set; }
        public int DepartmentId { get; set; }
    }
}
