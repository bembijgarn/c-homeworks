using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace HomeworkV3_t3
{
    internal class Program
    {
        static void Main()
        {
            #region TASK1
            Console.WriteLine("----------------------");
            Console.Write("Enter the size of array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n]; // odd  kenti, even luwi;
            int[] even = new int[n];
            int[] odd = new int[n];
            int index1 = 0;
            int index2 = 0;
            for (int i = 1; i <= arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[index1] = i;
                    index1++;
                }
                else
                {
                    odd[index2] = i;
                    index2++;
                }
            }
            Console.Write("EVEN NUMBERS : ");
            for (int i = 0; i < index1; i++)
            {
                Console.Write($" {even[i]}");
            }
            Console.WriteLine();
            Console.Write("ODD NUMBERS : ");
            for (int i = 0; i < index2; i++)
            {
                Console.Write($" {odd[i]}");
            }
            #endregion
            Console.WriteLine(); // new line;
            Console.WriteLine("-------------------------");
            #region TASK2
            Random random = new Random();
            Console.Write("Choose Array size : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[size];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = random.Next(size);
            }
            Console.Write("Array Numbers ");
            foreach (var e in arr2)
            {
                Console.Write($"{e}, ");
            }
            Console.Write("\n");
            var Count = from x in arr2 group x by x into q select q;
            foreach (var item in Count)
            {
                var Sum = item.Key * item.Count();
                Console.WriteLine($"{item.Key} appears {item.Count()} times, sum = {Sum}.");
            }
                        #endregion
            Console.WriteLine("-------------------");
            #region TASK3
            List<int> SUMS = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, };
            Console.Write("Enter the Result Amount(max) : ");
            int result = Convert.ToInt32(Console.ReadLine());
            int[] arr5 = new int[result];
            int indexOfArr5 = 0;
            foreach (var x in SUMS.OrderByDescending(x => x).Take(result))
            {
                arr5[indexOfArr5] = x;
                indexOfArr5++;
            }
            for (int i = 0; i < arr5.Length; i++)
            {
                Console.WriteLine($"TOP{i + 1} - {arr5[i]}.");
            }
            Console.Write("------------------------\n");
            #endregion
            #region MYTASK

            // Pick Number from the List and , Replace with Your Number

            bool yes = false;
            var list1 = new List<int>() { 55, 445, 12, 1, 3, 4, 5, 6, 10 };
            Console.Write("Numbers - ");
            foreach (var item in list1)
            {
                Console.Write($"{item} ");
            }
            Console.Write("\n");
            Console.Write("Pick a number to replace : ");
            int NNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pick a replace number : ");
            int replace = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] == NNumber)
                {
                    var found = list1.Where(a => a == NNumber).FirstOrDefault();
                    var index = list1.FindIndex(a => a == NNumber);
                    list1[index] = replace;
                    yes = true;
                    break;
                }
            }
            if (yes)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                foreach (var item in list1)
                {
                    Console.Write($"{item} ");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{replace} is not in Numbers.");
            }
            Console.ResetColor();
            #endregion

        }
    } 
}
