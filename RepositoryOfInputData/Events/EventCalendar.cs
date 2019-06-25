using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherClock.RepositoryOfInputData.Events
{
    public class EventCalendar
    {
        private static readonly List<Event> Events = new List<Event>();


        static EventCalendar()
        {
            {
                new Event
                {
                    Id = 1,
                    Title = "Встреча",
                    Description = "какое то описание события",
                    StartTime = new TimeSpan(14, 10, 0),
                    EndTime = new TimeSpan(16, 0, 0),
                };
            };

            {
                new Event
                {
                    Id = 2,
                    Title = "Конференция",
                    Description = "какое то описание события",
                    StartTime = new TimeSpan(12, 0, 0),
                    EndTime = new TimeSpan(16, 0, 0),
                };
            };

            {
                new Event
                {
                    Id = 3,
                    Title = "Практика",
                    Description = "какое то описание события",
                    StartTime = new TimeSpan(13, 30, 0),
                    EndTime = new TimeSpan(16, 0, 0),
                };
            };

            {
                new Event
                {
                    Id = 4,
                    Title = "Забрать посылку",
                    Description = "какое то описание события",
                    StartTime = new TimeSpan(15, 0, 0),
                    EndTime = new TimeSpan(15, 30, 0),
                };
            };
        }

        public List<Event> GetAll()
        {
            return new List<Event>(Events);
        }

        public Event Get(int id)
        {
            List<Event> events = GetAll();
            Event searchingEvent = events.FirstOrDefault(@event => @event.Id == id);
            return searchingEvent;
        }
    }
}
