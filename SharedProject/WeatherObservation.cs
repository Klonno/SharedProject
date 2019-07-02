using System;
using System.Collections.Generic;
using System.Text;

namespace SharedProject
{
    // POCO (simple) object
    class WeatherObservation
    {
        public Guid WeatherStationId { get; set; }
        public DateTime ObservationDateTime { get; set; }
        public double DegreesCelcius { get; set; }
        public double Humidity { get; set; }
    }
}
