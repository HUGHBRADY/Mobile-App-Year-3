using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

namespace MobileApp_Weather
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Banner
            Header.Text = "Rain or Shine";
        }

        private async void Current_Location(object sender, RoutedEventArgs e)
        {
            var position = await LocationManager.GetPosition();
            // Get the weather at the user's location
            RootObject myWeather = await WeatherData.GetWeather(position.Coordinate.Point.Position.Latitude, position.Coordinate.Point.Position.Longitude);

            // Icons taken from https://openweathermap.org/weather-conditions
            string icon = String.Format("ms-appx:///Assets/Icons/{0}.png", myWeather.weather[0].icon);
            Icon.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

            // Print city name, temperature and weather description from WeatherData.cs
            ResultTextBlock.Text = myWeather.name + " - " + myWeather.main.temp + " - " + myWeather.weather[0].description;
        }
    }
}
