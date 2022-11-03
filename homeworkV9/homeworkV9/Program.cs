using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using static System.Console;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace homeworkV9
{
    internal class Program
    {
        static void Main()
        {
            #region TASK1

            Task1 task = new Task1();
            task.file();
            #endregion
            Write("\n");
            #region TASK2

            inh ing = new();
            ing.Numb();
            #endregion
            Write("\n");
            #region TASK3

            Word word = new Word();
            word.Split();
            #endregion
            Write("\n");
            #region TASK4

            Nicolas nikz = new();
            nikz.Calculate();
            #endregion
            Console.Write("\n");
            #region TASK5

            Cypher cypher = new Cypher();
            cypher.Getnum();           
            #endregion
        }
    }
    interface ITasks
    {
        void file();
    }
   
}
