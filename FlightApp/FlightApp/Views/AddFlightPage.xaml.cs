using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightApp.ViewModels;
using Xamarin.Forms;

namespace FlightApp.Views
{
    public partial class AddFlightPage : ContentPage
    {
        public AddFlightPage()
        {
            this.BindingContext = new AddFlightViewModel();
            InitializeComponent();
        }
    }
}
