using System;

namespace FlightBookingSystem.Models
{
    public class AirlineModel : BaseClass
    {
        public String Name { get; set; }
        public Guid CountryOfOrigin { get; set; }
    }
}

