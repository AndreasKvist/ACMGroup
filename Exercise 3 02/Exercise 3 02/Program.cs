using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3_02
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccountClass account = new BankAccountClass("savings");

            
            Console.WriteLine(account.accountNumber);

         
            Console.WriteLine(account.dateOpened);

            Console.WriteLine(account.accountType);

            account.Deposit(200);
            account.Deposit(200);
            account.Deposit(200);

            account.Withdraw(400);

            Console.WriteLine(account.GetBalance());


            Console.ReadKey();

            //Console.WriteLine("Please enter balance");
            //BankAccountClass balance = new BankAccountClass();
            //Console.ReadLine();

            //Console.WriteLine("Please enter date of account creation");
            //BankAccountClass dateOpened = new BankAccountClass();
            //Console.ReadLine();

            //Console.WriteLine("Please state account type");
            //BankAccountClass accountType = new BankAccountClass();
            //Console.ReadLine();
            
        }
    }
}
