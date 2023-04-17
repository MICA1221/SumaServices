using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SumaWebService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int Sumar(int num1, int num2);
    }
}
