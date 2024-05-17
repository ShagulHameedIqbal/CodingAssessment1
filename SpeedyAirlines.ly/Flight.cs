namespace SpeedyAirlines.ly
{
    /// <summary>
    /// Represents a flight with specific attributes such as flight number, departure and arrival airports, scheduled day, and order capacity.
    /// </summary>
    public class Flight
    {
        public int FlightNumber { get; set; }
        public string? Departure { get; set; }
        public string? Arrival { get; set; }
        public int Day { get; set; }
        public int OrderCapacity { get; set; } = 20; // Default capacity is 20
    }

    /// <summary>
    /// Provides constants representing airport codes.
    /// </summary>
    public static class Airport
    {
        public const string YUL = "YUL";
        public const string YYZ = "YYZ";
        public const string YYC = "YYC";
        public const string YVR = "YVR";
    }

    /// <summary>
    /// Represents the days of the week.
    /// </summary>
    public enum DayOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    /// <summary>
    /// Represents the flight numbers for Speedy Airlines flights.
    /// </summary>
    public enum FlightNumber
    {
        SPAR1 = 1,
        SPAR2 = 2,
        SPAR3 = 3,
        SPAR4 = 4,
        SPAR5 = 5,
        SPAR6 = 6
    }

}
