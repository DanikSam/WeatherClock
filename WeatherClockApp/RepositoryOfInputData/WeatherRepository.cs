using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WeatherClock
{
    public class WeatherRepository
    {
        private readonly Dictionary<TimeSpan, int> _hourlyWeather = new Dictionary<TimeSpan, int>
        {
            { new TimeSpan(1, 0, 0), 12 },
            { new TimeSpan(2, 0, 0), 12 },
            { new TimeSpan(3, 0, 0), 13 },
            { new TimeSpan(4, 30, 0), 15 },
            { new TimeSpan(5, 0, 0), 19 },
            { new TimeSpan(6, 0, 0), 20 },
            { new TimeSpan(7, 0, 0), 25 },
            { new TimeSpan(8, 0, 0), 22 },
            { new TimeSpan(9, 0, 0), 23 },
            { new TimeSpan(10, 0, 0), 25 },
            { new TimeSpan(11, 0, 0), 24 },
            { new TimeSpan(12, 0, 0), 23 },
        };

        private List<HourlyWeatherDTO> newList = new List<HourlyWeatherDTO>();

        private void SetDTO()
        {
            HourlyWeatherDTO temp = null;
            foreach (var time in _hourlyWeather)
            {
                temp.hour = time.Key.Hours;
                temp.minute = time.Key.Minutes;
                temp.degree = time.Value;
                newList.Add(temp);
                Console.WriteLine(temp);
            }
        }

        public string GetHourlyWeather()
        {

            string result = JsonConvert.SerializeObject(_hourlyWeather);
            return result;
        }
    }
}
