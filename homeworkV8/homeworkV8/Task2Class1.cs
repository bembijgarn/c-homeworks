using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace homeworkV8
{


    public class bank : IFinanceOperations
    {
        public int CalculateLoanPercent(int month, double AmountPerMonth)
        {                      
            AmountPerMonth = month * 5; // 5 = percent per month
            return (int)AmountPerMonth;
        }
        public bool CheckUserHistory()
        {
            Random gen = new Random();
            int prob = gen.Next(100);
            return prob <= gen.Next(100);
        }
        

        
    }
    public class MicroFinance : IFinanceOperations
    {
        public int CalculateLoanPercent(int month, double AmountPerMonth)
        {
            Console.Write("Enter the Amount of the money : ");
            int money = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter loan duration : ");
            month = Convert.ToInt32(Console.ReadLine());
            int fullcomission = month * 4; // 4$ per month
            int percent = money * (10 / 100);
            return money + fullcomission + percent; 

           
        }
        
        
        public bool CheckUserHistory()
        {
            bool prob = true;
            return prob;
        }
    }

    





    interface IFinanceOperations
    {
        int CalculateLoanPercent(int month, double AmountPerMonth);
        bool CheckUserHistory();
    }
    

}

