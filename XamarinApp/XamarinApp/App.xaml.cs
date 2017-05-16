using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinApp
{
    public partial class App : Application
    {
        public App()
        {
            Resources.Functions funkcije = new Resources.Functions();
            InitializeComponent();

            MainPage = new XamarinApp.MainPage();
        }

        protected override void OnStart()
        {

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
