﻿using System;
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
        }

        // Go to CurrentLoc Page
        private void CurrentLo_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CurrentLoc));
        }

        // Go to ChooseLoc Page
        private void ChooseLo_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ChooseLoc));
        }
    }
}