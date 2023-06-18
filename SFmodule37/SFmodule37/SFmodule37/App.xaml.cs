﻿using SFmodule37.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SFmodule37
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new WelcomePage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
