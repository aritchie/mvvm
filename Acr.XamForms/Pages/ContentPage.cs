using System;


namespace Acr.XamForms {

    public class ContentPage : Xamarin.Forms.ContentPage {

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
