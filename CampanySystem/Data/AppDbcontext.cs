using CampanySystem.Models;
using Microsoft.EntityFrameworkCore;

namespace CampanySystem.Data
{
    public class AppDbcontext : DbContext
    {
        public DbSet<ApplicationUser> applicationUsers { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<EmployeeProject> employeeProjects { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<Department> departments  { get; set; }

        public AppDbcontext(DbContextOptions<AppDbcontext> db) : base(db)
        {
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasMany(e => e.employeeProjects)
                .WithOne(e => e.Employee)
                .HasForeignKey(fk => fk.EmployeeId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Project>().HasMany(e => e.employeeProjects)
            .WithOne(e => e.Project)
            .HasForeignKey(fk => fk.ProjectId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Project>().HasOne(e => e.Department)
        .WithMany(e => e.Projects)
        .HasForeignKey(fk => fk.DepartmentId)
        .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Employee>().HasOne(e => e.Department)
     .WithMany(e => e.employees)
     .HasForeignKey(fk => fk.DepartmentId)
     .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<EmployeeProject>()
                .HasIndex(e => new { e.ProjectId , e.EmployeeId})
                .IsUnique();


          

        }
    }
}
