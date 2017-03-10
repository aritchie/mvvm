using System;


namespace Acr.XamForms
{

    public class MasterDetailPage : Xamarin.Forms.MasterDetailPage
    {
        protected override bool OnBackButtonPressed()
        {
            return (this.BindingContext as IViewModelLifecycle)?.OnBack() ?? true;
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            (this.BindingContext as IViewModelLifecycle)?.OnActivate();
        }


        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            (this.BindingContext as IViewModelLifecycle)?.OnDeactivate();
        }
    }
}