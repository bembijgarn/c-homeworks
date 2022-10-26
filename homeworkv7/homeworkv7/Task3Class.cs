using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace homeworkv7
{
    internal class Task3Class
    {
    }
    public class Student1
    {
        public string Name { get; set; }


        public virtual void Study()
        {
            Console.WriteLine("Student is Studying");
        }
        public virtual void Read()
        {
            Console.WriteLine("Stundet is Reading");
        }
        public virtual void Write()
        {
            Console.WriteLine("Student is Writing");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Student is Relaxing");
        }
    }
    public class GoodStudent : Student1
    {
        public override void Study()
        {
            Console.WriteLine("Student Likes study");
        }
        public override void Read()
        {
            Console.WriteLine("Student Likes Read");
        }
        public override void Write()
        {
            Console.WriteLine("Student Likes Write");
        }
        public override void Relax()
        {
            Console.WriteLine("Student Relaxes rarely");
        }
    }
    public class LazyStudent : Student1
    {
        public override void Study()
        {
            Console.WriteLine("Student does not Like study");
        }
        public override void Read()
        {
            Console.WriteLine("Student Does not Like Read");
        }
        public override void Write()
        {
            Console.WriteLine("Student Does not Like Write");
        }
        public override void Relax()
        {
            Console.WriteLine("Student Likes Relax");
        }

    }
    public class ClassRoom
    {
        Student1 laasa = new();
        public ClassRoom(Student1 student)
        {
            this.laasa.Name = student.Name; 
        }
        public void lasaa(Student1 name)
        {
            name.Study();
            name.Read();
            name.Write();
            name.Relax();
            
        }

    }
}
