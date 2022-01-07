using System;
using TestApp.XamarinForms.Services;
using TestApp.XamarinForms.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp.XamarinForms
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
