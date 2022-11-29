using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions<PersonContext> options)
              : base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<AboutPerson> Abouts { get; set; }
       
    }
}
