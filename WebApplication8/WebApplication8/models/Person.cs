using System;

namespace WebApplication8.models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateTime { get; set; }
        public Adress PersonAdres { get; set; }
        public AboutPerson PersonAbout { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public Admins Admins { get; set; }
    }
    public static class Role
    {
        public const string Admin = "Admin";
        public const string User = "User";
    }
}
