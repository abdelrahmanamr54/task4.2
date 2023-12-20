using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4v2
{
    public class CheckingAccoun :Account
    {

        double rate ;
        public CheckingAccoun(string name = "Unnamed Account", double balance = 0.0) : base(name, balance)
        {
             rate = 1.5;
        }
        public bool Withdraw(double amount)
        {

            amount += rate;
            return base.Withdraw(amount);
            //if (balance - amount >= 0)
            //{
            //    balance -= amount;
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }


    }
}
