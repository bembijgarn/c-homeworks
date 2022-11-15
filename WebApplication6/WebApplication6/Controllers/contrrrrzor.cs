using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using WebApplication6.models;
using Newtonsoft.Json.Linq;
using System.Text.Json;
using System.IO;
using Newtonsoft.Json;

namespace WebApplication6.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class contrrrrzor : Controller
    {
        [HttpPost("Adduser")]
        public IActionResult NewUser(Person person)
        {
            var validator = new PersonValidator();
            var result = validator.Validate(person);
            var PersonList = new List<Person>();
            if (!result.IsValid)
            {
                return BadRequest(result.Errors[0].ErrorMessage);
            }
            var myperson1 = new Person()
            {
                Datetime = person.Datetime,
                FirstName = person.FirstName,
                LastName = person.LastName,
                JobPosition = person.JobPosition,
                Salary = person.Salary,
                WorkExperience = person.WorkExperience,
                PersonAdress = person.PersonAdress,
            };            
            PersonList.Add(myperson1);                     
            if (PersonList.Count == 0)
            {
                return BadRequest("Sorry user was not added");
            }
            else
            {                              
                return Ok(JPostmethod(PersonList));               
            }                                               
        }
        [HttpGet("getuser")]
        public IActionResult getUser()
        {
            
               return Ok(JGetmethod());
            
        }
        [HttpGet("userByIndex/{id}")]
        public IActionResult GetuserByIndex(int id)
        {
            return Ok(JbyIndex(id));
        }
        [HttpGet("Filteruser")]
        public IActionResult QueriUser([FromQuery] Person pers)
        {
            return Ok(QueryMethod());
        }
        [HttpDelete("DeleteUser{index}")]
        public IActionResult DeleteUser(int index)
        {
            var perzon = new List<Person>()
            {
                new Person()
                {
                 Datetime = DateTime.Now,
                FirstName = "zurab",
                LastName = "zviadauri",
                JobPosition = "judo",
                Salary = 1500,
                WorkExperience = 7,
                PersonAdress = new Adress()
                {
                    Country = "Georgia",
                    City = "Gurjaani",
                    HomeNumber = 67
                }
                },
                new Person()
                {
                 Datetime = DateTime.Now,
                FirstName = "Tom",
                LastName = "Mcdonald",
                JobPosition = "Manager",
                Salary = 1000,
                WorkExperience = 2,
                PersonAdress = new Adress()
                {
                    Country = "USA",
                    City = "NY",
                    HomeNumber = 10
                }
                },
                new Person()
                {
                 Datetime = DateTime.Now,
                FirstName = "Kate",
                LastName = "Grilish",
                JobPosition = "Dancer",
                Salary = 3500,
                WorkExperience = 1,
                PersonAdress = new Adress()
                {
                    Country = "United Kingdom",
                    City = "London",
                    HomeNumber = 98
                }
                }
            };
            perzon.RemoveAt(index);
            if (perzon.Count == 3)
            {
                return BadRequest("User was not deleted");
            }
            else
            {
                return Ok(perzon);
            }           
        }
        [HttpPut("Updateuser/")]
        public IActionResult Updateuser(int index,Person person)
        {
            var perzon = new List<Person>()
            {
                new Person()
                {
                 Datetime = DateTime.Now,
                FirstName = "zurab",
                LastName = "zviadauri",
                JobPosition = "judo",
                Salary = 1500,
                WorkExperience = 7,
                PersonAdress = new Adress()
                {
                    Country = "Georgia",
                    City = "Gurjaani",
                    HomeNumber = 67
                }
                },
                new Person()
                {
                 Datetime = DateTime.Now,
                FirstName = "Tom",
                LastName = "Mcdonald",
                JobPosition = "Manager",
                Salary = 1000,
                WorkExperience = 2,
                PersonAdress = new Adress()
                {
                    Country = "USA",
                    City = "NY",
                    HomeNumber = 10
                }
                },
                new Person()
                {
                 Datetime = DateTime.Now,
                FirstName = "Kate",
                LastName = "Grilish",
                JobPosition = "Dancer",
                Salary = 3500,
                WorkExperience = 1,
                PersonAdress = new Adress()
                {
                    Country = "United Kingdom",
                    City = "London",
                    HomeNumber = 98
                }
                }
            };
            perzon[index].Datetime = DateTime.Now;
            perzon[index].FirstName = person.FirstName;
            perzon[index].LastName = person.LastName;
            perzon[index].JobPosition = person.JobPosition;
            perzon[index].Salary = person.Salary;
            perzon[index].WorkExperience = person.WorkExperience;
            perzon[index].PersonAdress = person.PersonAdress;
            return Ok(perzon);
        }

       private static string JPostmethod(List<Person> list)
        {
            string JsonPath = @"C:\Users\lasha\source\repos\WebApplication6\WebApplication6\Person.json";
            var Js = JsonConvert.SerializeObject(list);
            System.IO.File.WriteAllText(JsonPath, Js);
            var json = JsonConvert.DeserializeObject(System.IO.File.ReadAllText(JsonPath));
            JsonDocument doc = JsonDocument.Parse(json.ToString());
            JsonElement root = doc.RootElement;
            return root.ToString();
        }
        private static string JGetmethod()
        {
            string JsonPath = @"C:\Users\lasha\source\repos\WebApplication6\WebApplication6\Person.json";
            var json = JsonConvert.DeserializeObject(System.IO.File.ReadAllText(JsonPath));
            JsonDocument doc = JsonDocument.Parse(json.ToString());
            JsonElement root = doc.RootElement;
            return root.ToString();
        }
        private static string JbyIndex(int index)
        {
            string JsonPath = @"C:\Users\lasha\source\repos\WebApplication6\WebApplication6\Person.json";
            string ByIndex = string.Empty;
            var json = JsonConvert.DeserializeObject(System.IO.File.ReadAllText(JsonPath));
            JsonDocument doc = JsonDocument.Parse(json.ToString());
            JsonElement root = doc.RootElement;
            for (int i = 0; i < root.GetArrayLength(); i++)
            {
                if (i == index)
                {
                    ByIndex = root[i].ToString();
                }
                else
                {
                    continue;
                }
            }
            
            return ByIndex;
        }
        private static string QueryMethod()
        {
            string JsonPath = @"C:\Users\lasha\source\repos\WebApplication6\WebApplication6\Person.json";
            string ByFilter = string.Empty;
            var json = JsonConvert.DeserializeObject(System.IO.File.ReadAllText(JsonPath));
            JsonDocument doc = JsonDocument.Parse(json.ToString());
            JsonElement root = doc.RootElement;
            for (int i = 0; i < root.GetArrayLength(); i++)
            {
                string Check;
                Check = root[i].GetProperty("Salary").ToString();
                string Check2 = root[i].GetProperty("City").ToString();
                if (Convert.ToDecimal(Check) > 1000 && Check2 != "Spain" )
                {
                    ByFilter = root[i].ToString();
                }
            }
            return ByFilter;
        }
        private static string DeleteMethod(List<Person>llist,int index)
        {
            var PPath = @"C:\Users\lasha\source\repos\WebApplication6\WebApplication6\DelJson.json";
            var Js = JsonConvert.SerializeObject(llist);
            System.IO.File.WriteAllText(PPath, Js);
            string ByFilter = string.Empty;
            var json = JsonConvert.DeserializeObject(System.IO.File.ReadAllText(PPath));
            JsonDocument doc = JsonDocument.Parse(json.ToString());
            JsonElement root = doc.RootElement;
            for (int i = 0; i < root.GetArrayLength(); i++)
            {
                string Check;
                Check = root[i].GetProperty("Salary").ToString();
                string Check2 = root[i].GetProperty("City").ToString();
                if (Convert.ToDecimal(Check) > 1000 && Check2 != "Spain")
                {
                    ByFilter = root[i].ToString();
                }
            }
            
            return "a";
        }
    }
   
    
}
