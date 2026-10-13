using AutoMapper;
using CampanySystem.Dtos;
using CampanySystem.Models;
using CampanySystem.Work;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampanySystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        protected readonly Iunitofwork unitofwork;
        protected readonly IMapper mapper;

        public DepartmentController(Iunitofwork unitofwork, IMapper mapper)
        {
            this.unitofwork = unitofwork;
            this.mapper = mapper;
        }



        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            var r = await unitofwork.Depart.GetAll();

            var d = mapper.Map<List<DepartmentDtos>>(r);
            return Ok(d);
        }

        [HttpGet("Id")]
        public async Task<IActionResult> GetId(int id)
        {
            var r = await unitofwork.Depart.GetById(id);

            var d = mapper.Map<DepartmentDtos>(r);
            return Ok(d);
        }
    }
}
