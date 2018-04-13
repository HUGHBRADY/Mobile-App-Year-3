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
    public sealed partial class ChooseLoc : Page
    {
        double lon;
        double lat;

        public ChooseLoc()
        {
            this.InitializeComponent();
        }

        private async void FindWeather_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lat = float.Parse(Latbox.Text);
                lon = float.Parse(Lonbox.Text);

                var position = await LocationManager.GetPosition();
                // Get the weather at the user's location
                RootObject myWeather = await WeatherData.GetWeather(lat, lon);

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
                TempTextBlock.Text = " ";                
                DescTextBlock.Text = " ";
                CityTextBlock.Text = "Unable to get weather.";
            }
        }

        // Go back home
        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
