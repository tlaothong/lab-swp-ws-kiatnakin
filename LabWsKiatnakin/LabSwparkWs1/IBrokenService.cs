using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LabSwparkWs1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBrokenService" in both code and config file together.
    [ServiceContract]
    public interface IBrokenService
    {
        [OperationContract]
        void Add(int a, int b);
        [OperationContract]
        void Add(double a, double b);
    }
}
