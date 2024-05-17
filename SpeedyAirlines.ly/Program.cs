namespace SpeedyAirlines.ly
{
    public class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            // User Story 1: Load flight schedule and display it
            var flightSchedule = FlightScheduler.GetFlightSchedule();
            Console.WriteLine("Flight Schedule\n");
            foreach (var flight in flightSchedule)
            {
                Console.WriteLine($"Flight: {flight.FlightNumber}, departure: {flight.Departure}, arrival: {flight.Arrival}, day: {flight.Day}");
            }

            // User Story 2: Load orders and assign them to flights
            var orders = OrderLoader.LoadOrders("OrderList.json");
            var itineraries = OrderScheduler.ScheduleOrders(flightSchedule, orders);
            Console.WriteLine("\nOrder Itineraries:");
            foreach (var itinerary in itineraries)
            {
                if (itinerary.FlightNumber.HasValue)
                {
                    Console.WriteLine($"Order: {itinerary.OrderId}, FlightNumber: {itinerary.FlightNumber}, Departure: {itinerary.Departure}, Arrival: {itinerary.Arrival}, Day: {itinerary.Day}");
                }
                else
                {
                    Console.WriteLine($"Order: {itinerary.OrderId}, FlightNumber: not scheduled");
                }
            }
        }
    }
}

