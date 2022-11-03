using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
using System.Xml;
using System.Data.SqlTypes;
using System.Xml.Linq;

namespace homeworkV9
{
    public class Word
    {
        public string Input { get; set; }

        public void Split()
        {
            dirmake dirmake = new dirmake();
            Word word = new Word();
            Write("Enter the String : ");
            word.Input = Convert.ToString(ReadLine());
            string First = "";
            string Last = "";
            for (int i = 0; i < (word.Input.Length + 1) / 2; i++)
            {
                First += word.Input[i];
            }
            for (int j = (word.Input.Length + 1) / 2; j < word.Input.Length; j++)
            {
                Last += word.Input[j];
            }
            dirmake.lasa(@"C:\Users\lasha\source\repos\homeworkV9\homeworkV9\", "XMLSTRING", "String.xml"); // parameter : file path, xmlfile , nameparameter.
            string XMLFILE = @"C:\Users\lasha\source\repos\homeworkV9\homeworkV9\XMLSTRING\String.xml";
            var document = new XmlDocument();
            document.Load(XMLFILE);
            XmlNode node = document.DocumentElement;
            XmlElement lala = document.CreateElement(First);
            Write("Enter the First Text for XML : ");
            lala.InnerText = Convert.ToString(ReadLine());
            node?.InsertBefore(lala, node.FirstChild);
            XmlElement element2 = document.CreateElement(Last);
            Write("Enterh the second Text for XML : ");
            element2.InnerText = Convert.ToString(ReadLine());
            node?.InsertAfter(element2, node.LastChild);
            document.Save(XMLFILE);
           
        }       
    }   
}            
