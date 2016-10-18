using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SimpleWebApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FirstWcfService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select FirstWcfService.svc or FirstWcfService.svc.cs at the Solution Explorer and start debugging.
    public class FirstWcfService : IFirstWcfService
    {
        public void DoWork()
        {
        }
    }
}
