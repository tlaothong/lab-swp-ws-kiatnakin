using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace LabSwparkWs1
{
    /// <summary>
    /// Summary description for SimpleWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SimpleWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string Greeting(string name)
        {
            var msg = string.Format("Hi, {0}. Current time here is {1}.", name, DateTime.Now);
            return msg;
        }
    }
}
