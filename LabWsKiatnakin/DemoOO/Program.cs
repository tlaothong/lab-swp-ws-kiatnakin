using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOO
{
    public class BankAccount
    {
        private double balance;

        public double Deposit(double amount)
        {
            balance += amount;
            return amount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var acc = new BankAccount();
            var r = acc.Deposit(200);
            Console.WriteLine(r);
        }
    }
}
