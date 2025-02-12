﻿using System;
using System.Collections.Generic;

namespace AM.UI.Console
{
    public class Flight
    {
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }
        public IList<Passenger> Passengers { get; set; }
        public Plane MyPlane { get; set; }

        public override string ToString()
        {
            return $"Flight {FlightId}: {Departure} to {Destination}, Date: {FlightDate}, Plane: {MyPlane?.PlaneType}";
        }
    }
}
