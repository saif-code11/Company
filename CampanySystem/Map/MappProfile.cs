using AutoMapper;
using CampanySystem.Dtos;
using CampanySystem.Models;

namespace CampanySystem.Map
{
    public class MappProfile : Profile
    {
        public MappProfile() 
        {
            CreateMap<DepartmentCreateDtos, Department>();
            CreateMap<Department, DepartmentDtos>();

            CreateMap<EmployeeCreateDtos, Employee>();
            CreateMap<Employee, EmployeeDtos>();

            CreateMap<ProjectCreateDtos, Project>();
            CreateMap<Project, ProjectDtos>();

            CreateMap<EmpPrjectCreateDtos, EmployeeProject>();
            CreateMap<EmployeeProject, EmpPrjectDtos>();
        }
    }
}
