using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace homeworkV10
{
   

    class facade
    {
        header header = new();
        body body = new();
        footer footer = new();

        public void html()
        {
            header.operationH();
            body.operationB();
            footer.operationF();
        }
    } 
    class header
    {
        public void operationH()
        {
            getinfo info = new();
            string elementtag = "header";
            info.getinf(elementtag);
        }
    }
    class body
    {
       public void operationB()
        {
            getinfo info = new();
            string elementtag = "p1";
            info.getinf(elementtag);
            
        }                
    }
    class footer
    {
       public void operationF()
        {
            getinfo info = new();
            string elementtag = "footer";
            info.getinf(elementtag);
        }
    }
    public class getinfo
    {
        public void getinf(string Elementtag)
        {
            var path = @"C:\Users\lasha\source\repos\homeworkV10\homeworkV10\html\index.html";
            var html = new XmlDocument();
            html.Load(path);

            XmlNodeList list = html.GetElementsByTagName(Elementtag);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].InnerText.ToString());
            }
        }

       
    }
    
    
}
