using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(BankBService.BankBService)))
            {
                host.Open();
                Console.WriteLine("Press ENTER to stop service.");
                Console.ReadLine();
                //host.Close();
            }
        }
    }
}
