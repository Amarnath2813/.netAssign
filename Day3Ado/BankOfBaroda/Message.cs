using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BankOfBaroda
{
     class Message
    {
        public void Email(double amt,double Balance,string Name)
        {
            Console.WriteLine("Email sent to {0}: Withdrawal of {1:C} from your account. Your current balance is {2:C}.",  Name,amt, Balance);
        }
        public void Mess(double amt,double Balance,string Name)
        {
            Console.WriteLine("Message sent to {0}: Withdrawal of {1:C} from your account. Your current balance is {2:C}.", Name, amt, Balance);
        }
    }
}
