


namespace UnitTestSharedProject
{
    using System;
    using SharedProject;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    class TestWeatherObservationClass
    {

        [TestMethod]
        public void TestWeatherObservation()
        {
            var stationId = Guid.NewGuid();

            var weatherObservation = new WeatherObservation {WeatherStationId = stationId, DegreesCelcius = 15.3, Humidity = 72.3, ObservationDateTime = DateTime.Now};
        }
    }
}
