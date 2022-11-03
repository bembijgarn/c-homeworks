using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkV9
{
    public class dirmake
    {
        public void lasa(string Dirpath,string Dirname,string filewithtype)
        {            
            string Makedir = Path.Combine(Dirpath, Dirname);
            if (!Directory.Exists(Makedir))
            {
                Directory.CreateDirectory(Makedir);
            }
            string takePath = new DirectoryInfo(Makedir).FullName;
            string filepath = $"{takePath}\\{filewithtype}";
            if (!File.Exists(filepath)) File.Create(filepath);
        }
    }
}
