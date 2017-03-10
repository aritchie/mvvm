using System;
using Xamarin.Forms;


namespace Sample
{
    public partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();
            this.MainPage = new Acr.XamForms.NavigationPage(new MainPage());
        }
    }
}
