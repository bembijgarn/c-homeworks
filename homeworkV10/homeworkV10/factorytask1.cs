using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkV10
{

    class artDecoChair : chair
    {
    }
    class artDecoSofa : sofa
    {
    }
    class artDecoCoffeTable : CoffeTable
    {
    }   
    class ragac : fact
    {
        public override chair CreateChair()
        {
            return new artDecoChair();
        }
        public override sofa CreateSofa()
        {
            return new artDecoSofa();
        }
        public override CoffeTable CreateCoffeTablle()
        {
            return new artDecoCoffeTable();
        }


    }
    public class Customer
    {
        private chair chair;
        private sofa sofa;
        private CoffeTable table;

        public Customer(fact factor)
        {
            chair = factor.CreateChair();
            sofa = factor.CreateSofa();   
            table = factor.CreateCoffeTablle();
        }
        
        

      

    }
}
