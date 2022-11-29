using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class AboutPerson
    {
        public int Id { get; set; }
        public string JobPosition { get; set; }
        public double Salary { get; set; }
        public double WorkExperience { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
