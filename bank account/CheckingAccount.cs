using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_account
{
     class CheckingAccount : BankAccount
     {
        private double _fee;

        public CheckingAccount(string accountName, double balance, double fee) : base(accountName, balance)
        {
            Fee = fee;
        }

        public double Fee
        {
            get => _fee;
            set
            {
                if (value > 0)
                    _fee = value;
                else
                    throw new Exception("Invalid value!");
            }
        }

         public override double Deposit(double amount)
         {
             base.Deposit(amount);
             Balance -=  Fee;
             return Balance;
         }

         public override double Withdraw(double amount)
         {
             if (amount > 0.0)
             {
                 Balance += amount;
                 Balance -= Fee;
                 return Balance;
             }

             throw new Exception("You cann't deposit a negative value!");

        }
    }
}
