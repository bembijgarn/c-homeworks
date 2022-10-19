using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Runtime.InteropServices;

namespace homeowrkv5
{
    internal class Program
    {
        static void Main()
        {
            #region task1
            decimal r = 5;
            decimal diametre = r * 2;
            decimal sqrt = diametre * diametre;
            decimal sqrt2S = (decimal)(5 * Math.Sqrt(Convert.ToDouble(2)));
            decimal sqrtA = sqrt2S * sqrt2S;// AREA;
            decimal sqrt2A = Math.Floor(sqrtA);
            decimal difference = sqrt - sqrt2A;
            Console.WriteLine(difference);
            #endregion
            Console.Write("\n");

            #region task2
            Console.WriteLine("Size range = 3-6.");
            Console.WriteLine("Size 3 = Deposit * 2.");
            Console.WriteLine("Size 4 = Deposit * 3.");
            Console.WriteLine("Size 5 = Deposit * 4.");
            Console.WriteLine("Size 6 = Deposit * 5.");
            Console.Write("Enter the Size : ");
            int sizee = Convert.ToInt32(Console.ReadLine());
            if (sizee < 3 || sizee > 6)
            {
                Console.WriteLine("Out Of Range");
            }
            else { 
            char[] chaars= new char[sizee];
            for (int i = 0; i < chaars.Length; i++)
            {
                Console.Write("Enter The Char : ");
                chaars[i] = Convert.ToChar(Console.ReadLine());
                    
            }
                for (int j = 0; j < chaars.Length; j++)
                {
                    if (chaars[j] == chaars[j + 1])
                    {
                        Console.WriteLine("YES");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("No");
                        break;
                    }
                }
            }
             #endregion
            Console.Write("\n");
            #region task3
            Console.WriteLine($"TEAM POINT = {Calculate(5,1,3)}."); //WIN,DRAW,LOOSE

           #endregion
            Console.Write("\n");
            #region task4
            List <int> Hours = new List<int>() {4,4,4,4,4,0,4};
            int SalarayPhour = 10;
            int Salary = 0;

            for (int i = 0; i < Hours.Count; i++)
            {
                if (Hours[i] == 0)
                {
                    continue;
                }
               if(i < Hours.Count - 2)
                {
                    Salary += Hours[i] * SalarayPhour;
                }
                if (i == Hours.Count - 2 || i == Hours.Count - 1)
                {
                    int XSalary = 20;
                    Salary += Hours[i] * XSalary;
                }
            }
            Console.Write($"Salary = {Salary}.");
            #endregion
            Console.Write("\n");
            #region task5
            List<int> results = new List<int>() {5,8,8,9,10};
            int count = results[0];
            int progress = 0;
            for (int i = 0; i < results.Count; i++)
            {
                if (results[i] > count)
                {
                    progress++;
                    count = results[i];
                }
            }
            Console.WriteLine($"Result = {progress}.");

            #endregion
            Console.Write("\n");
            #region task6
            Console.Write("Enter The Text Size : ");
            int size = Convert.ToInt32(Console.ReadLine());
            List<string> text = new List<string>() { "World", "Programming", "Monkey", "Keyboard", "Blizzard", "Roger" };
            for (int i = 0; i < text.Count; i++)
            {
                if (text[i].Length == size)
                {
                    Console.Write($"{text[i]},");
                }
                else if(i == text.Count - 1 && text[i].Length != size){
                    Console.Write("No Elements Found");
                }
            }
                      #endregion
        }
        static int  Calculate(int x, int y, int z)      // WIN,DRAW,LOOSE
        {
            /*x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());*/

            x *= 3;
            y *= 1;
            z *= 0;
            int sum = x + y + z;

            return sum;
        }
    }
}
