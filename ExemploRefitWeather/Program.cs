using Refit;
using System;
using System.Threading.Tasks;

namespace ExemploRefitWeather
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var OpenWeatherMap = RestService.For<ICityApiService>("http://api.openweathermap.org");
                Console.WriteLine("Informe a Cidade para ver a temperatura: ");

                string cidadeInformada = Console.ReadLine().ToString();
                Console.WriteLine($"Consultando informações do clima para a cidade: {cidadeInformada}");

                var address = await OpenWeatherMap.GetCityAsync(cidadeInformada);
                Console.Write($"\nTemperatura: {address.Temp}°C " +
                            $"\nTemperatura Máxima: {address.Temp_max}°C " +
                            $"\nTemperatura Mínima: {address.Temp_min}°C ");

            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro na consulta da cidade: {e.Message}");
            }
        }
    }
}
