using System.ServiceModel;
using SumaWcfService;

namespace SumaWcfService
{
    public class SumadorService : ISumadorService
    {
        public int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}

