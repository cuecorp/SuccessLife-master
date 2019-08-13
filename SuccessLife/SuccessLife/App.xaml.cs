using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace SuccessLife
{
    public partial class App : Application
    {
        public App()
        {
           // InitializeComponent();
            var tab = new TabbedPage();
            tab.Children.Add(new LocalHtmlBaseUrl { Title = "IBaseUrl" });
            MainPage = tab;
           // MainPage = new MainPage();
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
