namespace SpeedyAirlines.ly
{
    public static class FlightScheduler
    {
        /// <summary>
        /// Retrieves the schedule of flights for Speedy Airlines.
        /// </summary>
        /// <returns>A list of Flight objects representing the flight schedule.</returns>
        public static List<Flight> GetFlightSchedule()
        {
            try
            {
                return
            [
                new Flight { FlightNumber = (int)FlightNumber.SPAR1, Departure = Airport.YUL, Arrival = Airport.YYZ, Day = (int)DayOfWeek.Monday },
                new Flight { FlightNumber = (int)FlightNumber.SPAR2, Departure = Airport.YUL, Arrival = Airport.YYC, Day = (int)DayOfWeek.Monday },
                new Flight { FlightNumber = (int)FlightNumber.SPAR3, Departure = Airport.YUL, Arrival = Airport.YVR, Day = (int)DayOfWeek.Monday },
                new Flight { FlightNumber = (int)FlightNumber.SPAR4, Departure = Airport.YUL, Arrival = Airport.YYZ, Day = (int)DayOfWeek.Tuesday },
                new Flight { FlightNumber = (int)FlightNumber.SPAR5, Departure = Airport.YUL, Arrival = Airport.YYC, Day = (int)DayOfWeek.Tuesday },
                new Flight { FlightNumber = (int)FlightNumber.SPAR6, Departure = Airport.YUL, Arrival = Airport.YVR, Day = (int)DayOfWeek.Tuesday },
            ];
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while retrieving the flight schedule: {ex.Message}");
                throw;
            }

        }
    }
}
