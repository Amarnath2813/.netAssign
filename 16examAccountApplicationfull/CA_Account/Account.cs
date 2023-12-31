﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Q1.Create Console Appplication for Bank Of Baroda.
Create a  abstract class Account having member
a. Id [Let your application generate id, it is readonly]
b.Name[write getter, setter Method Give Validation Length of  name can not be less then 2 and greater then 15]
c.Balance[write getter, setter, you can not set value  outside class other than child class]
It has two methods
1. public abstract withdraw(double amt);
2. public void Deposit(double amt) { }
This method will increase amount in balance.
Create two child class SavingAccount and CurrentAccount.
In CurrentAccount user can have negative balance.
In SavingAccount minimum balance of 1000 need to maintain. Declare const double  minbala=1000
When use withdraw money they should get SMS and EMAIL about new balance and amount withdrawn.
 When you run application it should display name of bank. 
Create List of Account class and store child Object.
Do transaction and ensure user can not withdraw more then the balance. Also ensure it maintain minimum balance of 1000 in Saving Account.
In SavingAccount write public static double Payinterest(Employee e) this method will return interest amount  and increase the balance  If data is in-validation then your application should throw exception
 Your application should allow you to create only 5 object.
Your application should handle all exception.
Write user Define Exception for insufficient balance[If user try to withdraw more then minbalance in Saving Account] This class will print user name and transaction detail in a file.
In Account class Create event. When use withdraw money it should send SMS and E-mail [Complete Publisher subscriber design pattern]*/
namespace CA_Account
{
    public delegate  void wd(double amt, string name, double balance);
    abstract public class Account
    {

        public event wd Wdevent;
        private static int id;
        private string name;
        private double balance;
        public Account(string name, double balance)
        {
            ++id;
            if (id <= 5)
            {
                Name = name;
                Balance = balance;

            }
            else
            {
                throw new Exception(message:"Can't Create Object");
            }
           


        }
       static Account()
        {
            Console.WriteLine("Bank Of Badora");
        }

      


       public string Name { 

            set { 
                {
                    if (value.Length > 2 && value.Length < 15)
                    {
                        name = value;
                    }
                        
                   
                }
            }
                        
        get { return name; }
        }
        public double Balance { set {  balance = value; }
            get { return balance; }
        }
        public abstract double withdraw(double amt);
        public void Deposit(double amt)
        {
            Balance = Balance + amt;
        }
        public void onwithdraw(double amt, string name, double balance)
        {
            if(Wdevent != null)
            {
                Wdevent(amt, name, balance);
            }

        }
        public override string ToString()
        {
            return ($"Id = {id} Name={Name} Balance={Balance}");
        }




    }
}
