using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace homeworkV9
{
   public class Nicolas
    {
        public DateTime Current { get; set; }
        public DateTime BirthDay { get; set; }



        public void Calculate()
        {
            Nicolas nico = new();
            StreamReader readz = new StreamReader(@"C:\Users\lasha\source\repos\homeworkV9\homeworkV9\Json\birthday.json");
            string Json = readz.ReadToEnd();
           
            Nicolas nicolas = JsonConvert.DeserializeObject<Nicolas>(Json);
           
            nico.Current = DateTime.Now;
            nico.BirthDay = nicolas.BirthDay;

            Console.WriteLine(nico.Current);
            Console.WriteLine(nico.BirthDay);

            var Diff = (nico.BirthDay - nico.Current).TotalDays;
            Diff = Math.Floor(Math.Abs(Diff));
            Console.WriteLine($"{Diff} Days Left.");

        }
    }
}
