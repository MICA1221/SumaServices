using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace SumaApiClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int num1 = 3;
            int num2 = 5;

            // Consumir la Web API
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync($"https://localhost:44322/api/suma?num1={num1}&num2={num2}");
            string jsonResponse = await response.Content.ReadAsStringAsync();
            int sumaWebApi = JsonSerializer.Deserialize<int>(jsonResponse);
            Console.WriteLine($"Suma Web API: {sumaWebApi}");

            Console.ReadKey();
        }
    }
}
