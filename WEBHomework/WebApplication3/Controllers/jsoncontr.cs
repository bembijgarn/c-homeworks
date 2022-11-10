using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Numerics;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class jsoncontr
    {       
            public void Jsoninput(person pa)
            {           
            string json = File.ReadAllText(@"C:\Users\lasha\source\repos\jsonprac\jsonprac\lasa.json");
            string path = @"C:\Users\lasha\source\repos\WebApplication3\WebApplication3\appsettings.json";
            dynamic jsonObj = JsonConvert.DeserializeObject(json);
                      
            jsonObj["Person"]["FirstName"] = pa.Firstname;
            jsonObj["Person"]["LastName"] = pa.Lastname;
            jsonObj["Person"]["Doctor"] = pa.Doctor;
            jsonObj["Person"]["Datetime"] = pa.Datetime;

            string output = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
            File.WriteAllText(path, output); 
            }      
    }
}
