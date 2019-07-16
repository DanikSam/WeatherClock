using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherClock
{
    public class HourlyWeatherDTO
    {
        public int hour { get; set; }
        public int minute { get; set; }
        public int degree { get; set; }
    }
}
