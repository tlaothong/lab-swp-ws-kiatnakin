using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LabSwparkWs1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BrokenService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BrokenService.svc or BrokenService.svc.cs at the Solution Explorer and start debugging.
    public class BrokenService : IBrokenService
    {
        public void Add(double a, double b)
        {
            throw new NotImplementedException();
        }

        public void Add(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
