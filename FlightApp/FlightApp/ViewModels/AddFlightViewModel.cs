using FlightApp.Models;
using System.Windows.Input;
using Xamarin.Forms;

namespace FlightApp.ViewModels
{
    public class AddFlightViewModel : BindableObject
    {
        public ICommand SubmitCommand { get; set; }

        public string FlightNumber { get; set; }
        public string DepartingStation { get; set; }
        public string DepartureDate { get; set; }
        public string ArrivalStation { get; set; }
        public string ArrivalDate { get; set; }

        public AddFlightViewModel()
        {
            SubmitCommand = new Command(async() =>
            {
                var flight = new Flight
                {
                    FlightNumber = this.FlightNumber,
                    DepartingStation = this.DepartingStation,
                    DepartureDate = this.DepartureDate,
                    ArrivalStation = this.ArrivalStation,
                    ArrivalDate = this.ArrivalDate
                };

                await App.FlightService.AddFlight(flight);
            });
        }
    }
}
