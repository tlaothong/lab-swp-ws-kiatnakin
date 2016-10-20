using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BankBService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class BankBService : IBankBService
    {
        public static double Balance = InitialBalance;

        private const double InitialBalance = 9000;

        public double Deposit(double amount)
        {
            Console.WriteLine("Requesting deposit {0}.", amount);
            Balance += amount;
            Console.WriteLine("Balance after withdraw: {0}.", Balance);
            return amount;
        }
    }
}
