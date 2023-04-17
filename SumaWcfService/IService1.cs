using System.ServiceModel;

namespace SumaWcfService
{
    [ServiceContract]
    public interface ISumadorService
    {
        [OperationContract]
        int Sumar(int num1, int num2);
    }
}
