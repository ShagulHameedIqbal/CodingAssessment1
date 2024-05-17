using Newtonsoft.Json;

namespace SpeedyAirlines.ly
{
    
    public static class OrderLoader
    {
        /// <summary>
        /// Loads orders from a JSON file.
        /// </summary>
        /// <param name="filePath">The path to the JSON file containing the orders.</param>
        /// <returns>A list of Order objects loaded from the JSON file.</returns>
        public static List<Order> LoadOrders(string filePath)
        {
            var json = File.ReadAllText(filePath);
            var orderDict = JsonConvert.DeserializeObject<Dictionary<string, Order>>(json);
            return orderDict.Select(o => new Order { OrderId = o.Key, Destination = o.Value.Destination }).ToList();
        }
    }
}
