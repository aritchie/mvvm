using System;


namespace Acr.XamForms.Pages
{
    public class TabbedPage : Xamarin.Forms.TabbedPage
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
