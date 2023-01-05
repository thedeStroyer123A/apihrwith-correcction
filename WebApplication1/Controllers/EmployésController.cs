using Microsoft.AspNetCore.Mvc;
using ProjectRh_BLL.Interfaces;
using ProjectRh_BLL.Models;
using ProjectRh_BLL.Services;
using WebApplication1.Mapper;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class EmployésController :ControllerBase
    {
        private readonly IEmployésService _employés_service;

        public EmployésController(IEmployésService employés_service)
        {
            _employés_service = employés_service;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_employés_service.Get(id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_employés_service.GetAll());
        }

        [HttpPost]
        public IActionResult Insert(Employés_C employés)
        {
            return Ok(_employés_service.Insert(employés.ClientToEmployésBL()));
        }

        [HttpPut]
        public IActionResult Update(Employés_C employés)
        {
            return Ok(_employés_service.Update(employés.ClientToEmployésBL()));
        }



    }
}
