namespace SpeedyAirlines.ly
{
    public static class OrderScheduler
    {
        /// <summary>
        /// Schedules orders onto available flights based on destination and flight capacity.
        /// </summary>
        /// <param name="flights">The list of available flights.</param>
        /// <param name="orders">The list of orders to be scheduled.</param>
        /// <returns>A list of OrderItinerary objects representing the scheduled itineraries for each order.</returns>
        public static List<OrderItinerary> ScheduleOrders(List<Flight> flights, List<Order> orders)
        {
            var itineraries = new List<OrderItinerary>();
            var flightGroups = flights.GroupBy(f => f.Arrival).ToDictionary(g => g.Key, g => g.ToList());

            foreach (var order in orders)
            {
                if (flightGroups.ContainsKey(order.Destination))
                {
                    var assigned = false;
                    foreach (var flight in flightGroups[order.Destination])
                    {
                        if (flight.OrderCapacity > 0)
                        {
                            itineraries.Add(new OrderItinerary
                            {
                                OrderId = order.OrderId,
                                FlightNumber = flight.FlightNumber,
                                Departure = flight.Departure,
                                Arrival = flight.Arrival,
                                Day = flight.Day
                            });
                            flight.OrderCapacity--;
                            assigned = true;
                            break;
                        }
                    }
                    if (!assigned)
                    {
                        itineraries.Add(new OrderItinerary
                        {
                            OrderId = order.OrderId,
                            FlightNumber = null,
                            Departure = null,
                            Arrival = order.Destination,
                            Day = null
                        });
                    }
                }
                else
                {
                    itineraries.Add(new OrderItinerary
                    {
                        OrderId = order.OrderId,
                        FlightNumber = null,
                        Departure = null,
                        Arrival = order.Destination,
                        Day = null
                    });
                }
            }

            return itineraries;
        }
    }
}
