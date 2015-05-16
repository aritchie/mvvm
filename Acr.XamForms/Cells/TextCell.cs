using System;


namespace Acr.XamForms {

    public class TextCell : Xamarin.Forms.TextCell {

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
