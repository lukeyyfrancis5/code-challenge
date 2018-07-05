using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace bank_account
{
    class SavingsAccount : BankAccount
    {
        private double _interestRate;

        public SavingsAccount(string accountName, double balance, double interestRate) : base(accountName, balance)
        {
            InterestRate = interestRate;
        }

        public double InterestRate
        {
            get => _interestRate;
            set
            {
                if (value > 0)
                    _interestRate = value;
                else
                {
                    throw new Exception("invalid interest Rate");
                }
            }
        }

        public double CalculateInterest()
        {
            return Balance * InterestRate;
        }
    }

   
}
