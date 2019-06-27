using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WeatherClockApp.RepositoryOfInputData.Events;

namespace EventRepositoryTest
{
    [TestClass]
    public class EventCalendarTest
    {
        [TestMethod]
        public void EventCalendar_GetAll_NullEvents_AllEvents()
        {
            //Arrange
            var calendar = new EventCalendar();

            //Act
            List<Event> events = calendar.GetAll();

            //Assert
            Assert.AreEqual(4, events.Count);
        }

        [TestMethod]
        public void EventCalendar_Get_NullEvent_GetCorrectEvent()
        {
            //Arrange
            var calendar = new EventCalendar();
            Event @event = new Event
            {
                Id = 4,
                Title = "«абрать посылку",
                Description = "какое то описание событи€",
                StartTime = new TimeSpan(15, 0, 0),
                EndTime = new TimeSpan(15, 30, 0),
            };

            //Act
            Event event1 = calendar.Get(4);

            //Assert
            Assert.AreEqual(@event.Id, event1.Id);
            Assert.AreEqual(@event.Title, event1.Title);
            Assert.AreEqual(@event.StartTime, event1.StartTime);
            Assert.AreEqual(@event.EndTime, event1.EndTime);
        }
    }
}