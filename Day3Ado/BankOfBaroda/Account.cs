using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace BankOfBaroda
   
{
    public delegate void wi(double amt, double balance, string name);
    public  abstract class Account
    {
        public event wi withdrawl;
       
        private static int id;
        private string name;
        private double balance;
        static Account() {
            Console.WriteLine("Bank Of Baroda");
        }
       
        public Account(string name, double balance)
        {
            ++id;
            if (id < 4)
            {
                this.name = name;
                Balance = balance;
               
            }
            else
            {
                throw new Exception("Can't create a object");
            }
            
        }
        public string Name
        {
            get { return name; }
            set {
                if (value.Length < 2 && value.Length > 15)
                {
                    name = value;
                }
                }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public abstract void withdraw(double amt);
        public void deposit(double amt)
        {
            balance = balance+amt;

        }
        public void onWithdraw(double amt,double balance,string Name)
        {
            if (withdrawl != null)
            {
                withdrawl(amt,Balance,Name);
            }
        }
       
    } 
  
   
    public class Demo
    {
       
            static void Main(string[] args)
            {
               Message m = new Message();
                List<Account> accounts = new List<Account>();
                 accounts.Add(new SavingAccount("Amar",100000));
            accounts.Add(new CurrentAccount("Shriya", 90000));
            accounts.Add(new SavingAccount("Amar", 100000));
           

            for (int i = 0;i<2; i++)
                {
                accounts[i].withdrawl += m.Email;
                accounts[i].withdrawl += m.Mess;
            }
                accounts[0].deposit(1000000);
                accounts[0].withdraw(10000);

            }
        
    }
   
}