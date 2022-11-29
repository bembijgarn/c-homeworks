using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Datetime { get; set; }
        public Adress PAdress { get; set; }
        public AboutPerson Aboutpe { get; set; }
        //one-to-many

    }
}
