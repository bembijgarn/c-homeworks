using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkV10
{
    public abstract class chair
    {
    }
    public abstract class sofa 
    {
    }
    public abstract class CoffeTable
    {
    }
    public abstract class fact
    {
        public abstract chair CreateChair();
        public abstract sofa CreateSofa();
        public abstract CoffeTable CreateCoffeTablle();
    }

}
