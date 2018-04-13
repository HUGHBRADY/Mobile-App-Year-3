## Rain or Shine - Weather App
Author: Hugh Brady
Student ID: G00338260

# Introduction 
This app is my project submission for Mobile Applications Development 2 module

# Requirements:
- Well-designed UI that is fit for purpose and provides a good user experience.
- Uses local/roaming storage for storing data and/or settings that are necessary for or enhance this user experience.
- Demonstrates appropriate use of the sensors/hardware available on UWP capable devices
- Accelerometer, gyroscope, location services, sound, network service (connect to server for data), camera, multi touch gestures
- The app must be more than a simple information app. It must have interactivity as part of the design.

# What is it?
Rain or Shine is a Universal Windows Application that uses Geolocation and a weather API to tell the user the weather at their location or at any point of coordinates the user enters. 

# How to Run
- Download or clone this repository.
- Open MobileApp-Weather.sln with Visual Studio.
- Click on "Local Machine" on the toolbar.

# How it works
Rain or Shine employs a free web API found at https://openweathermap.org/api. When you request information from this API the data it returns is in JSON formatting. [Here is an example](http://samples.openweathermap.org/data/2.5/weather?lat=35&lon=139&appid=b6907d289e10d714a6e88b30761fae22) provided by openweathermap.org. I had to create classes in C# so that I could store the information for displaying to the user. This was done in a separate class (WeatherData.cs) from the rest of the app.