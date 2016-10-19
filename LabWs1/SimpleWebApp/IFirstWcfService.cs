using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SimpleWebApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFirstWcfService" in both code and config file together.
    [ServiceContract]
    public interface IFirstWcfService
    {
        [OperationContract]
        string NumToEng(int number);

        [OperationContract]
        string Add200(int number);

        [FaultContract(typeof(DivFault))]
        [OperationContract]
        int Div(int a, int b);
    }
}
