using DemoClassFamily.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DemoClassFamily
{
    /// <summary>
    /// Summary description for DemoYieldService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DemoYieldService : System.Web.Services.WebService
    {

        [WebMethod]
        public IEnumerable<Employee> ListAllEmployees()
        {
            return new Employee[]
            {
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
    }
}
