using Microsoft.EntityFrameworkCore;
using WebApplication8.models;

namespace WebApplication8
{
    public class personcontext : DbContext
    {
        public personcontext(DbContextOptions<personcontext> options) : base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<AboutPerson> AboutPerson { get; set; }
        public DbSet<Admins> Admins { get; set; }
        
    }
}
