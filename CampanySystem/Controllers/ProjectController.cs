using AutoMapper;
using CampanySystem.Dtos;
using CampanySystem.Work;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampanySystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        protected readonly Iunitofwork unitofwork;
        protected readonly IMapper mapper;

        public ProjectController(Iunitofwork unitofwork, IMapper mapper)
        {
            this.unitofwork = unitofwork;
            this.mapper = mapper;
        }



        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var r = await unitofwork.Pro.GetAll();

            var d = mapper.Map<List<ProjectDtos>>(r);
            return Ok(d);
        }

        [HttpGet("Id")]
        public async Task<IActionResult> GetId(int id)
        {
            var r = await unitofwork.Pro.GetById(id);

            var d = mapper.Map<ProjectDtos>(r);
            return Ok(d);
        }

    }
}
