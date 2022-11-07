using GemBox.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace homeworkV10
{
    class facadee
    {
        headder headerr = new();
        bodyy bodyy = new();
        footeer footerr = new();

        public void pdf()
        {
            headerr.operatiionH();
            bodyy.operatiionB();
            footerr.operatiionF();
        }
    }
    class headder
    {
        public void operatiionH()
        {
            getinf info = new();
            pd element = pd.header;
            info.getinff(element);
        }
    }
    class bodyy
    {
        public void operatiionB()
        {
            getinf info = new();
            pd element = pd.body;
            info.getinff(element);

        }
    }
    class footeer
    {
        public void operatiionF()
        {
            getinf info = new();
            pd element = pd.footer;
            info.getinff(element);
        }
    }
    public class getinf
    {
        public void getinff(pd pd)
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            var document = PdfDocument.Load("C:\\Users\\lasha\\source\\repos\\homeworkV10\\homeworkV10\\pdf\\smp.pdf");
            switch (pd)
            {
                case pd.header:
                    using (document)
                    {
                        List<char> lasa = new List<char>();
                        var a = document.Pages[0].Content.ToString();
                        string b = a.Substring(0,24);
                        Console.WriteLine(b);
                        Console.Write("\n");
                        Console.Write("\n");
                    }
                    break;
                case pd.body:
                    using (document)
                    {
                        List<char> lasa = new List<char>();
                        var a = document.Pages[0].Content.ToString();
                       
                        var b = a.Substring(39);

                        Console.WriteLine(b);
                        Console.Write("\n");
                    }
                    break;
                case pd.footer:
                    Console.WriteLine("Page 1");
                    break;
            }
        }        
    }
    public enum pd
    {
        header,
        body,
        footer
    }
}

