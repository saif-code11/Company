using CampanySystem.Genaricrepo;
using CampanySystem.Models;

namespace CampanySystem.Work
{
    public interface Iunitofwork
    {
        IgenaricRepo<Employee> emp {  get; set; }
        IgenaricRepo<Department> Depart {  get; set; }
        IgenaricRepo<Project> Pro {  get; set; }
        IgenaricRepo<EmployeeProject> emp_project {  get; set; }
        IgenaricRepo<ApplicationUser> User {  get; set; }

        void Save();
    }
}
