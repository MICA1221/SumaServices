using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SumaWebService
{
    public class Service1 : IService1
    {
        public int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
