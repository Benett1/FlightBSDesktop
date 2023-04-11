using System;

namespace FlightBookingSystem.Models
{
    public class FlightModel : BaseClass
    {
        public FlightModel() { }


        public Guid PlaneId { get; set; }
        public String DepartureAirport { get; set; }
        public String ArrivalAirport { get; set; }
        public DateTime DateTime { get; set; }

    }
}

