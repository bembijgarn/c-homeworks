using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkv7
{
    internal class Task2Class
    {
    }
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Enrollment { get; set; }
    
     public  string Subject()
        {
            List<string> Subjects = new List<string>() { "Math", "Chemistry", "English" , "Geography" };
            Random random = new Random();
            int index = random.Next(0, Subjects.Count);
            string subj = Subjects[index];
            return subj;
            
        }
        public int Countz ()
        {
            Student student = new Student();
            int Standart = 4;
            int Finally = Standart - student.Enrollment;
            return Finally;
        }
    }
    public class Teacher
    {
        public string Name { get; set; }
        public bool certified = true;

        

        public void Answer(string su)
        {
            Random ran = new Random();
            if (su == "Math")
            {
            int  answer =  ran.Next(100) + ran.Next(100);
                Console.WriteLine($"Subject = Math/ - {answer}.");
            }else if (su == "Chemistry")
            {
                Console.WriteLine($"Subject = Chemistry/ - Fe X"); //FERUM ;
            }else if (su == "English")
            {
                string answer = "WELCOME TO C#";
                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine("Invalid Subject");
            }
        }

    }
    

}
