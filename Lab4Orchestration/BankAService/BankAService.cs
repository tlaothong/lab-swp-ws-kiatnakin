using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BankAService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class BankAService : IBankAService
    {
        public static double Balance = InitialBalance;

        private const double InitialBalance = 20000;

        public double Withdraw(double amount)
        {
            Console.WriteLine("Requesting withdraw {0}.", amount);
            if (Balance >= amount)
            {
                Console.WriteLine("Withdraw granted");
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Withdraw rejected");
                return 0;
            }
            Console.WriteLine("Balance after withdraw: {0}.", Balance);
            return amount;
        }
    }
}
