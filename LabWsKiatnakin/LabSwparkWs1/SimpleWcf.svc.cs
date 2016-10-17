using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LabSwparkWs1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SimpleWcf" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SimpleWcf.svc or SimpleWcf.svc.cs at the Solution Explorer and start debugging.
    public class SimpleWcf : ISimpleWcf
    {
        public string Greeting(string name)
        {
            var msg = string.Format("Hello, {0}. Current time here is {1}.", name, DateTime.Now.ToLongTimeString());
            return msg;
        }
    }
}
