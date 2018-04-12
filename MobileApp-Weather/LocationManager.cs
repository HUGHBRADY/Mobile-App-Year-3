using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace MobileApp_Weather
{
    public class LocationManager
    {
        public async static void GetLocation()
        {
            var accessStatus = await Geolocator.RequestAccessAsync();
        }
    }
}
