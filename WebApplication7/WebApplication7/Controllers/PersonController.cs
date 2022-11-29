using DATA;
using Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using WebApplication7.Crud_methods;
using WebApplication7.Validation;

namespace WebApplication7.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private readonly PersonContext _context;
        private readonly CRUDS _cruds = new CRUDS();


        public PersonController(PersonContext context)
        {
            _context = context;
        }
        [HttpPost("AddPerson")]
        public IActionResult NewUser(Person person)
        {
            var validation = new PersonValidation();

            var result = validation.Validate(person);

            if (!result.IsValid)
            {
                return BadRequest(result.Errors[0].ErrorMessage);
            }
            else
            {
                var myperson1 = new Person()
                {
                    Datetime = person.Datetime,
                    Firstname = person.Firstname,
                    Lastname = person.Lastname,
                    PAdress = person.PAdress,
                    Aboutpe = new AboutPerson
                    {
                        Salary = person.Aboutpe.Salary,
                        WorkExperience = person.Aboutpe.WorkExperience,
                        JobPosition = person.Aboutpe.JobPosition,
                    }
                };

                _cruds.AddUser(myperson1, _context);
                return Ok("Person added in Database");
            }
        }
        [HttpGet("GetUsers")]
        public IActionResult GetUsers()
        {
            var datas = new List<string>();
            _cruds.GetUsers(_context, datas);
            return Ok(datas);
        }
        [HttpGet("UserbyID/{id}")]
        public IActionResult GetUserById(int id)
        {
            var FoundUser = new List<string>();
            _cruds.GetUserById(_context, id, FoundUser);
            return Ok(FoundUser);
        }
        [HttpGet("FilterUser")]
        public IActionResult FilterUser()
        {
            var FilterUser = new List<string>();
            _cruds.FilterUserData(_context, FilterUser);
            return Ok(FilterUser);
        }
        [HttpDelete("DeleteUserByID/{id}")]
        public IActionResult DeleteUserByID(int id)
        {
            _cruds.DeleteUserByID(_context, id);
            return Ok("Deleted");

        }
        [HttpPut("UpdateUserByID/")]
        public IActionResult UpdateUserByID(Person person, int id)
        {
            var validation = new PersonValidation();
            var result = validation.Validate(person);
            if (!result.IsValid)
            {
                return BadRequest(result.Errors[0].ErrorMessage);
            }
            else
            {

                var p = _context.Persons.Where(x => x.Id == id).FirstOrDefault();
                p.Firstname += "gamarjoba";

                _context.SaveChanges();
                var myperson = new Person()
                {
                    Datetime = person.Datetime,
                    Firstname = person.Firstname,
                    Lastname = person.Lastname,
                    PAdress = person.PAdress,
                    Aboutpe = new AboutPerson
                    {
                        Salary = person.Aboutpe.Salary,
                        WorkExperience = person.Aboutpe.WorkExperience,
                        JobPosition = person.Aboutpe.JobPosition,
                    }
                };
                _cruds.UpdateUserByID(person, _context, id);
                return Ok("User Updated");
            }
        }

    }
}


