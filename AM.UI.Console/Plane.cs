using System;
using System.Collections.Generic;

namespace AM.UI.Console
{
    public class Plane
    {
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public IList<Flight> Flights { get; set; } = new List<Flight>(); // Propriété de navigation

        public Plane() { }

        public Plane(PlaneType planeType, int capacity, DateTime manufactureDate)
        {
            PlaneType = planeType;
            Capacity = capacity;
            ManufactureDate = manufactureDate;
        }

        public override string ToString()
        {
            return $"PlaneId: {PlaneId}, Type: {PlaneType}, Capacity: {Capacity}, Manufacture Date: {ManufactureDate.ToShortDateString()}";
        }
    }
}
