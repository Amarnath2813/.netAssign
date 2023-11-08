using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankOfBaroda
{
    public class SavingAccount : Account
    {
        const double minbalance = 1000;
        public SavingAccount(String name, double balance) : base(name,balance)
        {
        }
        public override void withdraw(double amt)
        {
            if (amt > Balance)
            {
                throw new Exception("Insufficient balance can't withdraw more money");
            }
            else if (amt < minbalance)
            {
                throw new Exception("Insufficient balance");
            }
            else
            {
                double b = Balance;
                Balance=b - amt;
                onWithdraw(amt,Balance,Name);
               
            }

        }
        public static PayInterest(Employee e)
        {

        }
       
    }
}
