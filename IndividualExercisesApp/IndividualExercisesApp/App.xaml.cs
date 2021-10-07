using IndividualExercisesApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IndividualExercisesApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new HomeTabbedPage();
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
