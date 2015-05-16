using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountOperation
{
    class Account
    {
        public string accountNumber;
        public string customerName;
        public double amount;
        

        public double Deposit(double balance)
        {
            amount += balance;
            return amount;
        }

        public double Withdraw(double withdrawBalance)
        {
            amount -= withdrawBalance;
            return amount;

        }
        

    }
}
