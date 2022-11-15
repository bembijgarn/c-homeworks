using System;

namespace WebApplication6.models
{
    public class Person
    {
        public DateTime Datetime { get; set; }
        public string FirstName { get;set; }
        public string LastName { get;set; }
        public string JobPosition { get;set; }
        public double Salary { get;set; }   
        public double WorkExperience { get;set; }   
        public Adress PersonAdress { get;set; }
        

    }
}
