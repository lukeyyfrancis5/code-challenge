using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace bank_account
{
    public abstract class BankAccount
    {
        private string _accountName;
        public static int AccountNumbersetter = 1000;
        public int AccountNumber;
        public double Balance;
        private Queue<Transaction> Ledger;
        public BankAccount(string accountName, double balance)
        {
            _accountName = accountName;
            Balance = balance;
        }

        public virtual double Deposit(double amount)
        {
            if (amount > 0.0)
            {
                var dtransaction = new Transaction(){Amount = amount,Credit = true,TransactioDateTime = DateTime.Now};
                Balance += amount;
                Ledger.Enqueue(dtransaction);
                return Balance;

            }
             
            throw new Exception("You cann't deposit a negative value!");
        }


        // assuming that the Bank allowed unlimited overdrafting 
        public virtual double Withdraw(double amount)
        {
            var wTransaction = new Transaction() { Amount = amount, Credit = false, TransactioDateTime = DateTime.Now };
            Balance += amount;
            Ledger.Enqueue(wTransaction);

            if (Balance <= amount)
            {
                amount = Balance;
            }

            Balance -= amount;
            return amount;
        }

        public void InitializeInitBankAccount()
        {
            AccountNumber = ++AccountNumbersetter;
            Balance = 0.0;
        }
    }

    
}