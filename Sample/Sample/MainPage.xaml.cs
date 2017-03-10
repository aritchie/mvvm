using System;
using Xamarin.Forms;


namespace Sample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
			this.btnListView.Clicked += (sender, e) => this.Navigation.PushAsync(new ListPage());
        }
    }
}
