using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace FlightApp.Models
{
    public class Flight
    {
        [JsonProperty("Id")]
        public string Id { get; set; }

        [Version]
        public string Version { get; set; }

        public string FlightNumber { get; set; }
        public string DepartingStation { get; set; }
        public string DepartureDate { get; set; }
        public string ArrivalStation { get; set; }
        public string ArrivalDate { get; set; }
    }
}
