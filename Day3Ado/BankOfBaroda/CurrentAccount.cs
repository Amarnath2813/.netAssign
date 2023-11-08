using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankOfBaroda
{
    public class CurrentAccount:Account
    {
        public CurrentAccount(String name, double balance) : base(name, balance)
        {
        }
        public override void withdraw(double amt)
            {
            if (amt > Balance)
            {
                throw new Exception("Insufficient balance can't withdraw more money");
            }
            else
            {
                double d = Balance;
                Balance = d - amt;
                onWithdraw(amt, Balance, Name);
            }
           
        }
        
    }
}
