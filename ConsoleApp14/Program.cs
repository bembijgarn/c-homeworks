using System;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main()
        {
            #region amocana
            int pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount : ");
            int R = Convert.ToInt32(Console.ReadLine()); // RAODENOBA
            int sale = 100;
            int T = 0;
            
            switch (pin)
            {
                case 995:
                    if (R > sale)
                    {
                        T = 1;
                       Console.WriteLine("Payment : " +  ((R * T) - (R * T * 0.2)) + "USD.");
                    }
                    else
                    {
                        T = 1;
                        Console.WriteLine("Payment : " + T * R  + "USD");
                    }
                    
                    break;

                case 123:
                    if (R > sale ) {
                        T = 4;
                        Console.WriteLine("Payment : " + ((R * T) - (R * T * 0.2)) + "USD.");
                    }
                    else
                    {
                        T = 4;
                        Console.WriteLine("Payment : " + T * R + "USD");

                    }
                    break;
                case 34:
                    if (R > sale)
                    {
                        T = 3;
                        Console.WriteLine("Payment : " + ((R * T) - (R * T * 0.2)) + "USD.");
                    }
                    else
                    {
                        Console.WriteLine("Payment : " + T * R + "USD");
                    }
                    break;
                case 74:
                    if (R > sale)
                    {
                        T = 2;
                        Console.WriteLine("Payment : " + ((R * T) - (R * T * 0.2)) + "USD.");
                    }
                    else
                    {
                        Console.WriteLine("Payment : " + T * R + "USD");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Pin");
                    break;
            }


            #endregion




            #region task1
            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 5 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            #endregion
            Console.WriteLine("--------------------");
            #region task2
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(num1 + num2);
            if (num1 > num2)
            {
                Console.WriteLine(num1 - num2);
            }
            else
            {
                Console.WriteLine(num2 - num1);
            }
            Console.WriteLine(num1 * num2);
            if (num1 > num2 && (num1 != 0 && num2 != 0))
                { 
            Console.WriteLine(num1 / num2);
            }else if (num1 < num2 && (num1 != 0 && num2 != 0))
            { 
            Console.WriteLine(num2/num1);
            }
            else
            {
                Console.WriteLine("Not Allowed To Divide By Zero");
            }
            #endregion
            Console.WriteLine("-------------------");
            #region task3
            int q = 19;
            int w = 33;
            Console.WriteLine($"q aris : {q} , w aris {w}");
            int sacavi = q;
            q = w;
            w = sacavi;
            Console.WriteLine($"q aris : {q}, w aris {w}");
            #endregion
            Console.WriteLine("--------------------------");
            #region task4
            int NNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(NNum + " * " + i + " = " + NNum * i);
            }
            #endregion
            Console.WriteLine("-------------------------");
            #region task5
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 2; i < n; i+=2)
            {
                Console.WriteLine(i*i);
            }
            #endregion


        }
    }
   
}
