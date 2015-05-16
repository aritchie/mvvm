using System;


namespace Acr.XamForms {

    public class MasterDetailPage : Xamarin.Forms.MasterDetailPage {
        public bool BindChildLifecycle { get; set; }


        protected override void OnAppearing() {
            base.OnAppearing();
            this.BindingContext.TryViewModelActivate();
            if (this.BindChildLifecycle) {
                this.Master.BindingContext.TryViewModelActivate();
                this.Detail.BindingContext.TryViewModelActivate();
            }
        }


        protected override void OnDisappearing() {
            base.OnDisappearing();
            this.BindingContext.TryViewModelDeactivate();
            if (this.BindChildLifecycle) {
                this.Master.BindingContext.TryViewModelDeactivate();
                this.Detail.BindingContext.TryViewModelDeactivate();
            }
        }
    }
}
