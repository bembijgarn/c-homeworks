using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkV8
{
   public abstract class FileWorker
    {
        public int Size { get; set; }
        
        public abstract string FileType { get; set; }

        public abstract void Read();
        public abstract void Write();
        public abstract void Edit();
        public abstract void Delete();

   }
    public class Son : FileWorker
    {
        string file;
        public override string FileType
        {
            get => file;
            set => file = value;
        }
        public override void Read()
        {
            Console.WriteLine($"I Can read from {FileType} file with max storage {Size}");
        }
        public override void Write()
        {
            Console.WriteLine($"I Can write to {FileType} file with max storage {Size}");
        }
        public override void Edit()
        {
            Console.WriteLine($"I Can edit {FileType} file with max storage {Size}");
        }
        public override void Delete()
        {
            Console.WriteLine($"I Can delete from {FileType} file with max storage {Size}");
        }
        public void methods()
        {
            Write();
            Read();
            Delete();
            Edit();
        }
    }
    
    
}
