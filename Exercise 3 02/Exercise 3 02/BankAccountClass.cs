using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3_02
{
    class BankAccountClass
    {
        public BankAccountClass(string at)
        {
            Random rnd = new Random();
            accountNumber = rnd.Next (10000, 99999 );
            dateOpened = DateTime.Today.ToString("A");
            accountType = at;
            balance = 0;

        }
        public int accountNumber { get; set; }
        private double balance;
        public string dateOpened { get; set; }
        public string accountType { get; set; }
        
        public void Deposit(double amount)
        {
            balance = balance + amount;
        }
        
        public void Withdraw(double amount)
        {
            balance = balance - amount;
        }
        
        public double GetBalance()
        {
            return balance;
        }

    }

    }
