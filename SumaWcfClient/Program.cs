using System;
using ConsoleApplication.SumadorServiceReference;

namespace ConsoleApplication
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            SumadorServiceClient client = new SumadorServiceClient();

            int num1 = 5;
            int num2 = 10;
            int resultado = await client.SumarAsync(num1, num2);
            Console.WriteLine($"La suma de {num1} y {num2} es: {resultado}");

            client.Close();
        }
    }
}
