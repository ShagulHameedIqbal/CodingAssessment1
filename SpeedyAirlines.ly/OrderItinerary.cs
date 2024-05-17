namespace SpeedyAirlines.ly
{
    /// <summary>
    /// Represents an itinerary for an order, including flight details if assigned.
    /// </summary>
    public class OrderItinerary
    {
        public string? OrderId { get; set; }
        public int? FlightNumber { get; set; }
        public string? Departure { get; set; }
        public string? Arrival { get; set; }
        public int? Day { get; set; }
    }
}
