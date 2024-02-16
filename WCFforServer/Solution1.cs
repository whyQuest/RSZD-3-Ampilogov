using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFforServer
{
    [ServiceContract]
    public interface ITransferObject
    {
        [OperationContract]
        double Calculate(double a, double b, double x, double y);
        [OperationContract]
        double factorial(int n);
    }
}
