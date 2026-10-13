using AutoMapper;
using CampanySystem.Dtos;
using CampanySystem.Work;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampanySystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
        protected readonly Iunitofwork unitofwork;
        protected readonly IMapper mapper;

        public EmpController(Iunitofwork unitofwork, IMapper mapper)
        {
            this.unitofwork = unitofwork;
            this.mapper = mapper;
        }



        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var r = await unitofwork.emp.GetAll();

            var d = mapper.Map<List<EmployeeDtos>>(r);
            return Ok(d);
        }

        [HttpGet("Id")]
        public async Task<IActionResult> GetId(int id)
        {
            var r = await unitofwork.emp.GetById(id);

            var d = mapper.Map<EmployeeDtos>(r);
            return Ok(d);
        }

        [HttpGet("Name")]
        public async Task<IActionResult> Search(string name) 
        {
            var r = await unitofwork.emp.GetAll();

            var data = r.Where(x => x.Name.Contains(name)).ToList();
            var d = mapper.Map<List<EmployeeDtos>>(data);

            return Ok(d);

            
        }

        [HttpGet("Idbydepart")]
        [Route("/api/employees/By-department/")]
        public async Task<IActionResult> Idbydepart(int id)
        {
            var r = await unitofwork.emp.GetAll();

            var data = r.Where(e => e.DepartmentId == id).ToList();
            var d = mapper.Map<List<EmployeeDtos>>(data);

            return Ok(d);


        }
    }
}
