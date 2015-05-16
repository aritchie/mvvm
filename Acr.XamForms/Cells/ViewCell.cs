using System;


namespace Acr.XamForms {

    public class ViewCell : Xamarin.Forms.ViewCell {

        protected override void OnAppearing() {
            base.OnAppearing();
            this.BindingContext.TryViewModelActivate();
        }


        protected override void OnDisappearing() {
            base.OnDisappearing();
            this.BindingContext.TryViewModelDeactivate();
        }
    }
}
