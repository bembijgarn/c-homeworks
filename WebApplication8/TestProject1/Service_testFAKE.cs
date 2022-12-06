using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication8;
using WebApplication8.models;

namespace TestProject1
{
    public class Service_testFAKE : Iperservice
    {
        private readonly personcontext _context;
        
       /* public Service_testFAKE(personcontext context)
        {
            _context = context;
        }*/
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
            return User;
        }
        public IEnumerable<Person> FilterUsers()
        {
            var user = _context.Persons.Where(x => x.PersonAbout.Salary > 1500 && x.PersonAdres.Country == "georgia");

            return user;
        }
       public  Person UpdateUser(Person person, int id)
        {
            var user = _context.Persons.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                _context.Persons.Attach(person);
                
            };
            return (user);
        }
        public Person Register(Person person)
        {
            _context.Add(person);           
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


    }
}
