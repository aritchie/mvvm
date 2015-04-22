using System;
using Xamarin.Forms;


namespace Acr.XamForms.Pages {

    public class ViewModelContentPage : ContentPage {

		protected override void OnAppearing() {
			base.OnAppearing();
			var vm = this.BindingContext as IViewModelLifecycle;
			if (vm != null)
				vm.OnAppearing();
		}


		protected override void OnDisappearing() {
			base.OnDisappearing();
			var vm = this.BindingContext as IViewModelLifecycle;
			if (vm != null)
				vm.OnDisappearing();
		}
    }
}
