using JWT.Constants;
using JWT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var lista = EmployeeConstants.GetEmployees;
            return Ok(lista);

        }


        [HttpGet("{nombre}")]        
        public IActionResult BuscarUsuario(string nombre )
        {
            var usuarios = EmployeeConstants.GetEmployees.FirstOrDefault(x => x.FirstName == nombre);                       

            return Ok(usuarios);
        }

    }
}
