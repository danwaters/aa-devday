using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using FlightApp.Views;
using FlightApp.Services;

namespace FlightApp
{
    public class App : Application
    {
        public static FlightService FlightService { get; private set; }

        public App()
        {
            FlightService = new FlightService();
            // The root page of your application
            MainPage = new NavigationPage(new AddFlightPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
