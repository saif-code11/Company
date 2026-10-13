using System.ComponentModel.DataAnnotations;

namespace CampanySystem.Dtos
{
    public class DepartmentDtos
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

    }
    public class DepartmentCreateDtos 
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }
}
