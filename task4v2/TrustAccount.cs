using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4v2
{
    public class TrustAccount : SavingsAccount
    {
        int maxwithdraws;
        public TrustAccount(string name = "Unnamed Account", double balance = 0.0, double rate = 3.0) :base(name,balance,rate)
        {
            maxwithdraws = 0;

        }
        public bool Deposit(double amount)
        {
            amount = amount + (amount * rate / 100);
            if (amount > 5000)
            {
                amount +=50;
              return  base.Deposit(amount);
            }
            return base.Deposit(amount);


        }
        public bool Withdraw(double amount)
        {
            const int noOfWithdraw = 3;
            double maxbalance;
            maxbalance = 0.2 * balance;


            if (noOfWithdraw > maxwithdraws && amount<maxbalance)
            {
                return base.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("error!!");
            }
            return false;


            
        }



    }

}
