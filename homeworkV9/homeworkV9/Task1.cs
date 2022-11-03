using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace homeworkV9
{
    public  class Task1 : ITasks
    {
        public int NumberOfLines { get; set; }  

        public void file()
        {
            try
            {
                Task1 N = new();
                string dirpath = @"C:\Users\lasha\source\repos\homeworkV9\homeworkV9\"; // Paste "Your Path" 
                string dirname = "Inputs";
                string makedir = Path.Combine(dirpath, dirname);
                if (!Directory.Exists(makedir))
                {
                    Directory.CreateDirectory(makedir);
                }
                string takePath = new DirectoryInfo(makedir).FullName;
                string filepath = $"{takePath}\\Text.txt";
                if (!File.Exists(filepath)) File.Create(filepath);
                Write("Enther the number of lines in file : ");
                N.NumberOfLines = Convert.ToInt32(ReadLine());
                for (int i = 1; i <= N.NumberOfLines; i++)
                {
                    Console.Write($"Enter {i} Text : ");
                    string read = Console.ReadLine();
                    File.AppendAllText(filepath, read + "\n");
                }
                string filename = Path.GetFileName(filepath);
                string Last = File.ReadLines(takePath + "\\" + filename).Last();
                Console.Write("\n");
                Console.Write("Last Line - ");
                Console.ForegroundColor = ConsoleColor.Red;
                WriteLine(Last);
                Console.ResetColor();
            }catch (Exception)
            {
                ForegroundColor = ConsoleColor.Green;WriteLine("DONE! Please Rerun Application.");Console.ResetColor();
            }
        } 
    }
    
}
