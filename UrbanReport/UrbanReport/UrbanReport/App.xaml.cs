using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.WindowsAzure.MobileServices;
using UrbanReport.Model;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace UrbanReport
{
    public partial class App : Application
    {

        //public static MobileServiceClient MobileService =
        //   new MobileServiceClient("https:/travelrecord.azurewebsites.net");
        public static User user = new User();
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }


        protected override void OnStart()
        {
            // Handle when your app starts
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
