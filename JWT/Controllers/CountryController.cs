using JWT.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var listcountry = CountryConstants.Countrys;
            return Ok(listcountry);
        }

        [HttpGet("{pais}")]
        public IActionResult BuscarUsuario(string nombreciudad)
        {
            var ciudad = CountryConstants.Countrys.FirstOrDefault(x => x.name == nombreciudad);

            return Ok(ciudad);
        }
    }
}
