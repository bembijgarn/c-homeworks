using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Any;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System;
using WebApplication8.models;

namespace WebApplication8.Controllers
{

    [Authorize]
    [Route("api/[controller]")]
    public class personcontr : Controller
    {
        private Iperservice _service;
        private readonly AppSettings _appSettings;

        public personcontr(Iperservice userservice, IOptions<AppSettings> appsettings)
        {
            _service = userservice;
            _appSettings = appsettings.Value;
        }
        [AllowAnonymous]
        [HttpPost("Registration")]
        public IActionResult Registration([FromBody] Person person)
        {
            _service.Register(person);
            return Ok(person);
        }
        [AllowAnonymous]
        [HttpPost("LOGG")]
        public IActionResult Login([FromBody] Person person)
        {
            var user = _service.Login(person);
            if (user == null)
                return BadRequest("Username or password is incorrect");
            string token = GenerateToken(user);
            return Ok(new
            {
                Id = user.Id,
                Username = user.Username,
                Password = user.Password,
                Role = user.Role,
                Token = token
            });
        }
        [Authorize(Roles = Role.Admin)]
        [HttpGet("ALLUSER")]
        public IActionResult GetUsers()
        {
            var users = _service.GettAll();
            return Ok(users);
        }
        [HttpGet("{id}")]
        public IActionResult byid(int id)
        {
            var currentUserId = int.Parse(User.Identity.Name);
            if (id != currentUserId && !User.IsInRole(Role.Admin))
                return Forbid();

            var user = _service.getbyid(id);

            if (user == null)
                return NotFound();

            return Ok(user);
        }
        [Authorize(Roles = Role.Admin)]
        [HttpDelete("Deleteuserbyid/{id}")]
        public IActionResult Deleteuserbyid(int id)
        {
            _service.Deleteuserbyid(id);         
            return Ok("Deleted");
        }
        [HttpGet("FilterUsers")]
        public IActionResult FilterUsers()
        {
            return Ok(_service.FilterUsers());
        }
        [Authorize(Roles = Role.Admin)]
        [HttpPut("{id}")]
        public IActionResult Updateuserbyid([FromBody]Person person,int id)
        {
           
           
              var user = _service.UpdateUser(person,id);
            
            return Ok(user);
        }






        private string GenerateToken(Person person)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.SecretWord);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, person.Id.ToString()),
                    new Claim(ClaimTypes.Role, person.Role.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            return tokenString;
        }
        }
}
