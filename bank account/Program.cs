using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_account
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BankAccount user = new BankAccount("Luke", 20000.00);
            
            Console.WriteLine(user.Withdraw(50));
            Console.WriteLine(user.Balance);
        //    Console.WriteLine(user.Deposit(233));
        //    Console.WriteLine(user.Balance);              
        }
    }
}
