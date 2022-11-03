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
    public abstract class Task2
    {
        public abstract int Number { get; set;}

    }
    public class inh : Task2
    {
        int num;
        public override int Number {
            get => num;
            set => num = value;
        }
        public  void Numb()
        {
            inh inn = new ();
            string Dirpath = @"C:\Users\lasha\source\repos\homeworkV9\homeworkV9\"; // Paste "Your Path" 
            string Dirname = "Numbers";
            string Makedir = Path.Combine(Dirpath, Dirname);
            if (!Directory.Exists(Makedir))
            {
                Directory.CreateDirectory(Makedir);
            }
            string TakePath = new DirectoryInfo(Makedir).FullName;
            string Filepath = $"{TakePath}\\Numbers.txt";
            Console.Write("Enter the number : ");
            inn.Number = Convert.ToInt32(ReadLine());
            for (int i = 1; i <= inn.Number; i++)
            {
                for (int j = 1; j < 10;j++)
                {
                    string display = $"{i} * {j} = ";
                    int mult = i * j;
                    File.AppendAllText(Filepath, display + mult + "\n");
                }
            }
        }        
    }
}
