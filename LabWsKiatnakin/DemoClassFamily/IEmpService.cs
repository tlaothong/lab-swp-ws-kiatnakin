using DemoClassFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DemoClassFamily
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmpService" in both code and config file together.
    [ServiceContract]
    public interface IEmpService
    {
        [OperationContract]
        void AddNewEmployee(Employee emp);
        [OperationContract]
        IEnumerable<Employee> ListAllEmployees();
        [OperationContract]
        void SetNumOfEmployee(Manager manager, int numOfEmployees);
    }
}
