using System;
using DATA;
using Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication7.Crud_methods
{
    public class CRUDS
    {
        public void AddUser(Person per, PersonContext con)
        {
            con.Add(per);
            con.SaveChanges();
        }
        public void GetUsers(PersonContext con,List<string> Data)
        {
            var Persons = con.Persons.ToList();
            foreach (var item in Persons)
            {
                Data.Add(item.Firstname);
            }                
        }
        public void GetUserById(PersonContext con,int id,List<string>User)
        {
            var persons = con.Persons.Find(id);
            User.Add(persons.Firstname);
            User.Add(persons.Lastname);
            
        }
        public void FilterUserData(PersonContext con,List<string>User)
        {
            var person = con.Persons.Where(x => x.Aboutpe.Salary > 2500 && x.PAdress.Country != "India");
            foreach (var item in person)
            {
                User.Add(item.Firstname);
            }
        }
        public void DeleteUserByID(PersonContext con,int id)
        {
            var person = con.Persons.Find(id);
            con.Remove(person);
            con.SaveChanges();
        }
        public void UpdateUserByID(Person per,PersonContext con,int id)
        {
            var person = con.Persons.FirstOrDefault();
            person.Firstname += "laoo";
            person.Firstname = per.Firstname;
            person.Lastname = per.Lastname;
            person.Datetime = per.Datetime;
            person.Aboutpe.JobPosition = per.Aboutpe.JobPosition;
            person.Aboutpe.Salary = per.Aboutpe.Salary;
            person.Aboutpe.WorkExperience = per.Aboutpe.WorkExperience;
            person.PAdress.Country = per.PAdress.Country;
            person.PAdress.City = per.PAdress.City;
            person.PAdress.HomeNumber = per.PAdress.HomeNumber;
            con.SaveChanges();
        }
        
    }
}
