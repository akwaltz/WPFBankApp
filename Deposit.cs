using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppB
{
    class Deposit
    {

        public double deposit(double amount, double balance)
        {
            return balance + amount;
        }

        public Deposit(double amount, double balance)
        {
            this.amount = amount;
            this.balance = balance;
        }
    }
}
