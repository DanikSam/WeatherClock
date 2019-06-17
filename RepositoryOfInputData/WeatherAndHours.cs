using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherClock
{
    public class Repository
    {
        private readonly Dictionary<int, int> _hourlyWeather = new Dictionary<int, int>
        {
            { 1, 12 },
            { 2, 12 },
            { 3, 13 },
           // { 4, 15 },
            { 5, 19 },
            { 6, 20 },
            { 7, 25 },
            { 8, 22 },
            { 9, 23 },
           // { 10, 25 },
            { 11, 22 },
            { 12, 23 },
        };

        public Dictionary<int, int> GetHourlyWeather()
        {
            /*            var dict = new Dictionary<int, int>();
                        for ( int i = 1; i < 13; i++ )
                        {
                            dict[i] = i + 10;
                        }
                        return string.Join(" ", dict);*/
            return _hourlyWeather;
        }
    }
}
