using System;
using System.Windows.Input;
using Acr;
using Xamarin.Forms;


namespace Sample
{
    public class MainViewModel : LifecycleViewModel
    {
        public MainViewModel()
        {
            this.NavToListView = new Acr.Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushModalAsync(new ListPage());
            });
        }


        public ICommand NavToListView { get; }
    }
}
