using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherClock
{
    public class WeatherRepository
    {
        private readonly Dictionary<int, int> _hourlyWeather = new Dictionary<int, int>
        {
            { 1, 12 },
            { 2, 12 },
            { 3, 13 },
            { 4, 15 },
           // { 5, 19 },
            { 6, 20 },
            { 7, 25 },
            { 8, 22 },
            { 9, 23 },
            { 10, 25 },
            { 11, 22 },
            { 12, 23 },
        };

        public String GetHourlyWeather()
        {
            string result = JsonConvert.SerializeObject(_hourlyWeather);
            return result;
        }
    }
}
