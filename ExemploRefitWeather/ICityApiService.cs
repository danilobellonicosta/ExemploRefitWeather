using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExemploRefitWeather
{
    public interface ICityApiService
    {
        [Get("/data/2.5/weather?q={city}&appid=8f22c80bde13c7d74dd9cd0286f83476&units=metric&lang=pt_br")]
        Task<OpenWeatherMapResponse> GetCityAsync(string city);
    }
}
