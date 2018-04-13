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
    public sealed partial class CurrentLoc : Page
    {
        public CurrentLoc()
        {
            this.InitializeComponent();

            // Banner
            Header.Text = "What's it like outside?";
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                var position = await LocationManager.GetPosition();
                // Get the weather at the user's location
                RootObject myWeather = await WeatherData.GetWeather(position.Coordinate.Point.Position.Latitude, position.Coordinate.Point.Position.Longitude);

                // Icons taken from https://openweathermap.org/weather-conditions
                string icon = String.Format("ms-appx:///Assets/Icons/{0}.png", myWeather.weather[0].icon);
                Icon.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));

                // Print city name, temperature and weather description from WeatherData.cs
                TempTextBlock.Text = myWeather.main.temp + "°C";
                CityTextBlock.Text = myWeather.name;
                DescTextBlock.Text = myWeather.weather[0].description;
            }
            catch
            {
                DescTextBlock.Text = "Unable to get weather.";
            }
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
