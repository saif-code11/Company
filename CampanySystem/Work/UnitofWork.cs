using CampanySystem.Data;
using CampanySystem.Genaricrepo;
using CampanySystem.Models;

namespace CampanySystem.Work
{
    public class UnitofWork : Iunitofwork
    {
        public IgenaricRepo<Employee> emp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IgenaricRepo<Department> Depart { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IgenaricRepo<Project> Pro { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IgenaricRepo<EmployeeProject> emp_project { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IgenaricRepo<ApplicationUser> User { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        protected readonly AppDbcontext appDbcontext;

        public UnitofWork(IgenaricRepo<Employee> emp, IgenaricRepo<Department> depart, IgenaricRepo<Project> pro, IgenaricRepo<EmployeeProject> emp_project, IgenaricRepo<ApplicationUser> user, AppDbcontext appDbcontext)
        {
            this.emp = emp;
            Depart = depart;
            Pro = pro;
            this.emp_project = emp_project;
            User = user;
            this.appDbcontext = appDbcontext;
        }

        public void Save()
        {
            appDbcontext.SaveChanges();
        }
    }
}
