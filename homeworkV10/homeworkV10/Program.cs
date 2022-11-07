using System;
using System.IO;
using System.Net;
using System.Reflection.Metadata;
using System.Xml;
using System.Xml.Serialization;
using HtmlAgilityPack;

namespace homeworkV10
{
    internal class Program
    {
        static void Main()
        {
            #region TASK!
            Customer customer = new Customer(new ragac());
            #endregion
            Console.Write("\n");
            #region TASK2
            actor Actor = new actor();
            Console.Write("ACTOR - ");
            Actor.obligation();
            stuntman Stuntman = new stuntman();
            Console.Write("STUNTMAN - ");
            Stuntman.obligation();
            Stuntman.obligation2();
            #endregion
            Console.Write("\n");
            #region TASK3
            Console.WriteLine("H T M L ");
            facade html = new();
            html.html();
            Console.WriteLine("P D F");
            facadee pdf = new();
            pdf.pdf();
            #endregion
            Console.Write("\n");
            #region TASK4
            strategy str;
            str = new strategy(new zip());
            str.consol();
            str = new strategy(new json());
            str.consol();
            str = new strategy(new txt());
            str.consol();

            #endregion













        }
    }
}
