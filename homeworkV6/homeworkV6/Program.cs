using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography;
using Microsoft.VisualBasic.FileIO;

namespace homeworkV6
{
    internal class Program
    {        
        static void Main()
        {                    
            #region task1
            
            Console.WriteLine($"Number in Range = {task1(49,71,2)}.");
            #endregion
            Console.Write("\n");
            #region task2
            Console.Write("Enter Socks : ");
            string pair = Convert.ToString(Console.ReadLine().ToUpper());
            findSock(pair);
            #endregion
            Console.Write("\n");
            #region task3
            Console.Write("First String : ");
            string first = Convert.ToString(Console.ReadLine());
            Console.Write("Second String : ");
            string second = Convert.ToString(Console.ReadLine());            
            if (second.Length > first.Length)
            {
                var temp = first;
                first = second;
                second = temp;
            }
            Console.WriteLine(LastDuplicates(first,second));

            #endregion
            Console.Write("\n");
            #region task4
            
            List<string> case1 = new List<string>();
            List<int> case2 = new List<int>();
            List<bool> case3 = new List<bool>();
            int option;

            do
            {
               
                    Console.WriteLine("|----------MENU------------------|");
                    Console.WriteLine("| 1.STRING                       |");
                    Console.WriteLine("| 2.INT                          |");
                    Console.WriteLine("| 3.BOOL                         |");
                    Console.WriteLine("| 4.EXIT                         |");
                    Console.WriteLine("|---------MENU-------------------|");
                    Console.Write("Option : ");
                    option = Convert.ToInt32(Console.ReadLine());
                 
                
               
                switch (option)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Enter Size of !STRING! List :");
                            int size = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < size; i++)
                            {
                                Console.Write($"STRING index of {i} : ");
                                case1.Add(Convert.ToString(Console.ReadLine()));                               
                            }
                            Console.WriteLine("TO upper----");
                            foreach (var item in case1)
                            {
                                Console.WriteLine($"{item.ToUpper()}");
                            }
                            
                        }catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }break;
                    case 2:
                        try
                        {
                            Console.Write("Enter Size of !INT! List : ");
                            int sizee = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < sizee; i++)
                            {
                                Console.Write($"INT index of {i} : ");
                                case2.Add(Convert.ToInt32(Console.ReadLine()));
                                
                            }
                            Task4(case2);
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }break;
                    case 3:
                        try
                        {
                            Console.Write("Enter Size of !BOOL! List : ");
                            int sizeee = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < sizeee; i++)
                            {
                                Console.Write($"BOOL index of {i} : ");
                                case3.Add(Convert.ToBoolean(Console.ReadLine()));
                            }
                            Console.Write("\n");
                            Task4(case3);
                        }catch(Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }break;
                    default:Console.WriteLine("Option Range 1-4");
                        break;
                                                                      
                }
            } while (option != 4);


            #endregion
            Console.WriteLine();
            #region task5


            task6(12345);


            #endregion
        }

        static int Task1Recursion(int number, int count)
        {            
            if (count == 1)
            {
                return number;
            }
            else {                
                return number * Task1Recursion(number, count - 1);
            }                              
           
        }
        static int task1(int a,int b, int n)
        {
            int result = 0;
            if (a > b)
            {
                Console.WriteLine("Invalid Range!!!");

            }
            else
            {
                for (int i = 1; i <= Math.Floor((decimal)b / 2); i++)
                {
                    if (i * Task1Recursion(i, n - 1) >= a && i * Task1Recursion(i, n - 1) < b)
                    {
                        result++;
                    }
                }
            }
            return result;
        }
        static void findSock(string pair)
        {            
            int pairs = 0;
            var freq = from x in pair group x by x into y select y;
            foreach (var neekush in freq)
            {
                if (neekush.Count() % 2 == 0)
                {
                    pairs++;
                }
            }
            Console.Write(pairs);
        }
        static string LastDuplicates(string first,string second)
        {            
            string dups = "";
            string finall = "";
            for (int i = second.Length - 1; i >= 0; i--)
            {
                if (first[i+(first.Length - second.Length)] != second[i])
                {
                    break;
                }
                else
                {
                    dups += second[i];
                }
            }
            
            for (int k = dups.Length - 1; k >= 0; k--)
            {
                finall += dups[k];
            }            
            return finall;            
        }
        static void Task4<T>(List<T>Value)
        {                       
            if (typeof(T) == typeof(string))
            {
                foreach (var item in Value.ToString())
                {
                    Console.Write($"{item},");
                }
            }else if (typeof(T) == typeof(int))
            {
                int sum = 0;
                foreach (var item in Value)
                {
                    sum += Convert.ToInt32(item);
                }
                Console.WriteLine($"Sum = {sum}.");
            }else if (typeof(T) == typeof(bool))
            {
                Console.WriteLine($"First Element is {Value.First()}\n");
                Console.WriteLine($"Last Element is {Value.Last()}\n");
                Console.WriteLine($"Middle Element is {Value[Value.Count/2]}\n");
            }
           
        }
        static void task6(int number)
        {
            if (number < 10)
            {
                Console.Write($"{number}-");
                return;
            }
            task6(number / 10); 
            Console.Write($"{number % 10}-");
        }
    }       
}


