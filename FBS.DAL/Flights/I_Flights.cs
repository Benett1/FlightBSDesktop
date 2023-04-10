using FlightBookingSystem.Models;
using System;
using System.Collections.Generic;

namespace FBS.DAL
{
    public interface I_Flights
    {
        List<FlightModel> GetFlights();
        FlightModel GetFlightById(Guid Id);
        void AddFlight(FlightModel flightModel);
        void UpdateFlight(FlightModel flightModel);
        void DeleteFlight(Guid Id);
    }
}
