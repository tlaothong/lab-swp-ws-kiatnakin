using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DemoClassFamily.Models;

namespace DemoClassFamily
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmpService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmpService.svc or EmpService.svc.cs at the Solution Explorer and start debugging.
    public class EmpService : IEmpService
    {
        public void AddNewEmployee(Employee emp)
        {
        }

        public IEnumerable<Employee> DemoYield()
        {
            yield return new Manager
            {
                EmployeeCode = "IT005",
                FirstName = "John",
                LastName = "Doe",
            };
            yield return new Employee
            {
                EmployeeCode = "IT006",
                FirstName = "Tom",
                LastName = "Hanks",
            };
            yield return new Employee
            {
                EmployeeCode = "IT007",
                FirstName = "James",
                LastName = "Bond",
            };
        }

        public IEnumerable<Employee> ListAllEmployees()
        {
            return new Employee[]
            {
                new Manager
                {
                    EmployeeCode = "IT005",
                    FirstName = "John",
                    LastName = "Doe",
                },
                new Employee
                {
                    EmployeeCode = "IT006",
                    FirstName = "Tom",
                    LastName = "Hanks",
                },
                new Employee
                {
                    EmployeeCode = "IT007",
                    FirstName = "James",
                    LastName = "Bond",
                }
            };
        }

        public void SetNumOfEmployee(Manager manager, int numOfEmployees)
        {
            manager.NumOfEmployees = numOfEmployees;
        }
    }
}
