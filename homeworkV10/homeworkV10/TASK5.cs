using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace homeworkV10
{
    class strategy
    {
        meth lasa;
        public strategy(meth strat)
        {
            this.lasa = strat;
        }
        public void consol()
        {
            lasa.algorithm();
        }
    }
    public abstract class meth
    {
        public abstract void algorithm();
    }
    public class zip : meth
    {
        public override void algorithm()
        {
            string backupdirname = "backup";
            string rootdir = new DirectoryInfo(@"C:\Users\lasha\source\repos\homeworkV10\homeworkV10\").FullName;
            string backuppath = Path.Combine(rootdir, backupdirname);
            if (!Directory.Exists(backuppath))
            {
                Directory.CreateDirectory(backuppath);
            }

            string zippath = @"C:\Users\lasha\source\repos\homeworkV10\homeworkV10\myfil\aa.zip";
            string extractpath = new DirectoryInfo(backuppath).FullName;
            ZipFile.ExtractToDirectory(zippath, extractpath);

            Console.WriteLine("Extract succcesfull");



        }
    }
    public class json : meth
    {
        public override void algorithm()
        {
            StreamReader read = new StreamReader(@"C:\Users\lasha\source\repos\homeworkV10\homeworkV10\js.json");
            string js = read.ReadToEnd();
            var m = JsonConvert.DeserializeObject(js);
            Console.WriteLine();
            Console.WriteLine(m);
        }
    }
    public class txt : meth
    {
        public override void algorithm()
        {
            var path = @"C:\Users\lasha\source\repos\homeworkV10\homeworkV10\lasa.txt";
            FileInfo fi = new FileInfo(path);
            if (fi.Extension == ".txt")
            {
                File.Delete(path);
            }
        }
    }
}
