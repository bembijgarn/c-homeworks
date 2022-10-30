using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace homeworkV8
{
    internal class Program
    {
        static void Main()
        {
            #region TASK1 
            Console.ForegroundColor = ConsoleColor.Red;
            Son son = new Son()
            {
                Size = 10,
                FileType = "txt"              
            };
            son.methods();
            Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Son son2 = new Son()
            {
                Size = 20,
                FileType = "PDF"
            };
            son2.methods();
            Console.ResetColor();
            #endregion
            Console.Write("\n");
            #region TASK2

            bank Ban = new bank();
            if (Ban.CheckUserHistory() == true)
            {
                Console.Write("Enter loan duration : ");
                int month = Convert.ToInt32(Console.ReadLine());
                double amount = month * 5; // percent per month
                Console.Write($"Sum of Percent in {month} month = {Ban.CalculateLoanPercent(month,amount)}%.");
            }
            else
            {
                Console.WriteLine("No story ");
            }
            Console.Write("\n");
            MicroFinance Micro = new MicroFinance();
            int x = 0;
            double d = 0;
            Console.WriteLine($"{Micro.CalculateLoanPercent(x,d)} $.");

            #endregion
        }
    }
}
