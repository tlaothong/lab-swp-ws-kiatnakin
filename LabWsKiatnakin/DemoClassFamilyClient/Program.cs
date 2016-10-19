using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClassFamilyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var svc = new EmpSvc.EmpServiceClient();

            var man = new EmpSvc.Manager()
            {
                EmployeeCode = "HR32398",
                FirstName = "John",
                LastName = "Doe",
            };

            svc.SetNumOfEmployee(man, 50);

            Console.WriteLine("{0} {1} has {2} employees.",
                man.FirstName,
                man.LastName,
                man.NumOfEmployees);

            var emps = svc.ListAllEmployees();
            foreach (var emp in emps)
            {
                Console.WriteLine("{0}:{1}  {2}",
                    emp.EmployeeCode,
                    emp.FirstName,
                    emp.LastName);
            }

            var tom = new EmpSvc.Employee()
            {
                EmployeeCode = "IT008",
                FirstName = "Tom",
                LastName = "Cruise"
            };

            svc.AddNewEmployee(man);
            Console.WriteLine("Tom has been added.");
        }
    }
}
