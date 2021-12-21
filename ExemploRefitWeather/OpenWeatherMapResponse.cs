using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploRefitWeather
{
    [System.Serializable]
    public class OpenWeatherMapResponse
    {
         
        [JsonProperty("temp")]
        public string Temp { get; set; }
        [JsonProperty("temp_min")]
        public string Temp_min { get; set; }
        [JsonProperty("temp_max")]
        public string Temp_max { get; set; }
    }
}
