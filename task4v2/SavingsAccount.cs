using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4v2
{
    public class SavingsAccount :Account
    {
        public double rate { get; set; }


        public SavingsAccount( string name = "Unnamed Account", double balance = 0.0, double rate = 3.0) :base(name,balance)
            
        {
            this.rate = rate;
            
            

        }
        public bool Deposit(double amount)
        {
            amount = amount + (amount * rate / 100);
           return base.Deposit(amount);
        }
        public override string ToString()
        {
              return $"[Account: {name}: {balance}]"; ;
            
        }

    }
}
