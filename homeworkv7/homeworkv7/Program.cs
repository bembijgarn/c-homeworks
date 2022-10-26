using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;

namespace homeworkv7
{
    internal class Program
    {
        static void Main()
        {
            #region Task1            
            Company check = new();
            Employee Person = new();
            Console.WriteLine();
            Console.Write("Enter The Name : ");
            Person.Name = Convert.ToString(Console.ReadLine());
            Console.Write("Enter The Last_Name : ");
            Person.LastName = Convert.ToString(Console.ReadLine());
            Console.Write("Enter The Age : ");
            Person.age = Convert.ToInt32(Console.ReadLine());
            Person.WorkHours = new List<int>();
            int Role;
            for (int i = 0; i < 7; i++) // 7 = WEEKDAYS
            {
                Console.Write("Enter Daily Work Hours : ");
                Person.WorkHours.Add(Convert.ToInt32(Console.ReadLine()));
            }
            do
            {
                Console.Clear();
                Console.WriteLine("1.Manager");
                Console.WriteLine("2.Developer");              
                Console.WriteLine("3.Tester");
                Console.WriteLine("4.Director");
                Console.WriteLine("5.Doctor");
                Console.WriteLine("6.Exit");
                Console.WriteLine("Type 6 If You Want To Exit");
                Console.Write("Enter the Role NUmber : ");
                Role = Convert.ToInt32(Console.ReadLine());
                switch (Role)
                {
                    case 1:
                        Person.position = (position)Role;
                        break;
                    case 2:
                        Person.position = (position)Role;
                        break;
                    case 3:
                        Person.position = (position)Role;
                        break;

                }
            } while (Role != 6);
            Console.WriteLine($"PERSON WEEKLE SALARY = {Employee.dolarebi(Person.WorkHours,Person.position)}$.");
            if (check.inside == true)
            {
                var a = Employee.dolarebi(Person.WorkHours,Person.position) * 18 / 100;
                Console.WriteLine($"You work in our Country , Budget received Your Salary's 18 % = {a}$.");
            }
            else
            {
                var b = Employee.dolarebi(Person.WorkHours, Person.position) * 5 / 100;
                Console.WriteLine($"You work as REMOTE , Budget received Your Salary's 5 % =  {b}$.");
            }
            #endregion
            Console.Write("\n");
            #region Task2
            Student student = new();
            Teacher teacher = new();
            Console.Write("Enter The Student Name : ");
            student.Name = Convert.ToString(Console.ReadLine());
            Console.Write("Enter The Student Age : ");
            student.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Student Enrollment Year : ");
            student.Enrollment = Convert.ToInt32(Console.ReadLine());
            string Subject = student.Subject();
            int YearsLeft = student.Countz();           
            Console.WriteLine($"The Student has {YearsLeft - student.Enrollment} Years Left.");
            teacher.Answer(Subject);
            #endregion
            Console.Write("\n");
            #region Task3
            Student1 student2 = new();
            student2.Name = "john";           
            ClassRoom classroom = new ClassRoom(student2);
            classroom.lasaa(student2);



            #endregion
        }
    }
    


    public enum position
    {
        Manager = 1,
        Developer = 2,
        Tester = 3,
        Director = 4,
        Doctor = 5
    }
    
}
