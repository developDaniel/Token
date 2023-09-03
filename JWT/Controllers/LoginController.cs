using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using JWT.Constants;
using JWT.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _config;
         

        public LoginController(IConfiguration config)
        {
            _config = config;
        }


        [HttpPost]
        public IActionResult Login(LoginUser userLogin)
        {

            var user = Authentication(userLogin);

            if (user != null)
            {
                // crear token
                var token = Generate(user);

                return Ok(token);
            }

            return NotFound("User no encontrado");
        }

        private UserModel Authentication(LoginUser login)
        {

            var usuarios = UserConstants.Users.FirstOrDefault(x => x.Username.ToLower() == login.UserName.ToLower()
            && x.Password == login.Password);

            if (usuarios != null)
                return usuarios;

            return null;
        }

        private string Generate(UserModel user)
        {
            var securitykey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:key"]));
            var credentials = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256);

            //Crear clains
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier,user.Username),
                new Claim(ClaimTypes.Email,user.EmailAddress),
                new Claim(ClaimTypes.GivenName,user.FirstName),
                new Claim(ClaimTypes.Surname,user.LastName),
                new Claim(ClaimTypes.Role,user.Rol),

            };

            //crear token
            var token = new JwtSecurityToken(
                _config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
