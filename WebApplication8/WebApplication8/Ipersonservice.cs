using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication8.models;

namespace WebApplication8
{
    public interface Iperservice
    {
        Person Login(Person person);
        IEnumerable<Person> GettAll();
        Person getbyid(int id);
        Person Register(Person person);
        Person Deleteuserbyid(int id);
        IEnumerable<Person> FilterUsers();
        Person UpdateUser(Person person,int id);
    }

    public class Ipersonservice : Iperservice
    {
        private readonly personcontext _context;
        public Ipersonservice(personcontext context)
        {
            _context = context;
        }
        private List<Person> users = new List<Person>
        {
            new Person
            {
                Id = 1,
                FirstName = "lasha",
                LastName = "sharvashidze",
                Username = "lasha111",
                Password = "lasha000",
                Role = Role.Admin },

             new Person
            {
                Id = 2,
                FirstName = "mamaci",
                LastName = "kaci",
                Username = "xato",
                Password = "xatuchi",
                Role = Role.Admin },

        };
        public Person Register(Person person)
        {
            _context.Add(person);
            _context.SaveChanges();
            
           
            return person;
        }
        public Person Login(Person person)
        {

            if (string.IsNullOrEmpty(person.Username) || string.IsNullOrEmpty(person.Password))
                return null;
            var user = _context.Persons.SingleOrDefault(x => x.Username == person.Username);

            if (user == null)
                return null;
            if (person.Password != user.Password)
                return null;
            return user;
        }
        public IEnumerable<Person> GettAll()
        {
            return _context.Persons;
        }
        public Person getbyid(int id)
        {           
            return _context.Persons.Find(id);
        }
        public Person Deleteuserbyid(int id)
        {
            var User = _context.Persons.Find(id);
            _context.Remove(User);
            _context.SaveChanges();
            return User;
        }
        public IEnumerable<Person> FilterUsers()
        {
            var user = _context.Persons.Where(x => x.PersonAbout.Salary > 1500 && x.PersonAdres.Country == "georgia");

            return user;
        }
        public Person UpdateUser(Person person,int id)
        {
            var user = _context.Persons.FirstOrDefault(x => x.Id == id);                      
            if (user != null)
            {
                _context.Persons.Attach(person);
                _context.SaveChanges();
            };


            return (user);

        }
      


    }
}
