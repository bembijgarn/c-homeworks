using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkV10
{
    public abstract class actorobl
    {
        public abstract void  obligation();
    }
    public abstract class stuntmanobl
    {
        public abstract void obligation();
        public abstract void obligation2();
    }
    public class actor : actorobl
    {
        public override void obligation()
        {
            Console.WriteLine("easy scenes.");
        }
    }
    public class stuntman : stuntmanobl
    {
        public override void obligation()
        {
            Console.Write(" filming, ");
        }
        public override void obligation2()
        {
            Console.WriteLine("hard scenes.");
        }
    }
}
