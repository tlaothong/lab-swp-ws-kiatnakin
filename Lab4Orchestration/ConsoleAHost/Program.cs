using System;
using System.ServiceModel;

namespace ConsoleAHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(BankAService.BankAService)))
            {
                host.Open();
                Console.WriteLine("BankA Service has started successfully.");
                Console.WriteLine("Press ENTER to stop service.");
                Console.ReadLine();
                //host.Close();
            }
        }
    }
}
