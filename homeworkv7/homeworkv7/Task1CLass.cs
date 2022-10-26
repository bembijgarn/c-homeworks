using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkv7
{
    internal class Task1CLass
    {
    }
    public class Company
    {
        public bool inside = true;
    }
    public class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int age { get; set; }
        public position position { get; set; }

        public List<int> WorkHours = new List<int>();



        public static int dolarebi(List<int> lasa, position pos)
        {
            Employee employee = new Employee();
            int WeekHours = 0;
            int Phour;
            int standart = 8;
            int Salary = 0;
            int Bonuse = 5;
            switch (pos)
            {
                case position.Manager:
                    Phour = 40;
                    for (int i = 0; i < lasa.Count; i++)
                    {
                        if (i < lasa.Count - 2 && lasa[i] <= standart)
                        {
                            Salary += lasa[i] * Phour;

                        }
                        else if (i < lasa.Count - 2 && lasa[i] > standart)
                        {

                            Salary += lasa[i] * Phour + (Bonuse * (lasa[i] - standart));
                        }
                        if (i >= lasa.Count - 2)
                        {
                            int extra = Phour * 2;
                            Salary += lasa[i] * extra;
                        }
                    }
                    break;
                case position.Developer:
                    Phour = 30;
                    for (int i = 0; i < lasa.Count; i++)
                    {
                        if (i < lasa.Count - 2 && lasa[i] <= standart)
                        {
                            Salary += lasa[i] * Phour;

                        }
                        else if (i < lasa.Count - 2 && lasa[i] > standart)
                        {

                            Salary += lasa[i] * Phour + (Bonuse * (lasa[i] - standart));
                        }
                        if (i >= lasa.Count - 2)
                        {
                            int extra = Phour * 2;
                            Salary += lasa[i] * extra;
                        }
                    }
                    break;
                case position.Tester:
                    Phour = 20;
                    for (int i = 0; i < lasa.Count; i++)
                    {
                        if (i < lasa.Count - 2 && lasa[i] <= standart)
                        {
                            Salary += lasa[i] * Phour;

                        }
                        else if (i < lasa.Count - 2 && lasa[i] > standart)
                        {

                            Salary += lasa[i] * Phour + (Bonuse * (lasa[i] - standart));
                        }
                        if (i >= lasa.Count - 2)
                        {
                            int extra = Phour * 2;
                            Salary += lasa[i] * extra;
                        }
                    }
                    break;
                default:
                    Phour = 10;
                    for (int i = 0; i < lasa.Count; i++)
                    {
                        if (i < lasa.Count - 2 && lasa[i] <= standart)
                        {
                            Salary += lasa[i] * Phour;

                        }
                        else if (i < lasa.Count - 2 && lasa[i] > standart)
                        {

                            Salary += lasa[i] * Phour + (Bonuse * (lasa[i] - standart));
                        }
                        if (i >= lasa.Count - 2)
                        {
                            int extra = Phour * 2;
                            Salary += lasa[i] * extra;
                        }
                    }
                    break;



            }
            foreach (var item in employee.WorkHours)
            {
                WeekHours += item;
            }

            if (WeekHours > 50)
            {
                Salary += Salary * (20 / 100);
            }
            return Salary;

        }
    }

}
