using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using FlightApp.Models;
using FlightApp.ViewModels;

namespace FlightApp.Services
{
    public class FlightService
    {
        private IMobileServiceClient client;

        public FlightService()
        {
            client = new MobileServiceClient("https://aa-devday.azurewebsites.net");
        }

        public async Task AddFlight(Flight flight)
        {
            await client.GetTable<Flight>().InsertAsync(flight);
        }

        public async Task<List<Flight>> GetAllFlights()
        {
            return await client.GetTable<Flight>().ToListAsync();
        }
    }
}
