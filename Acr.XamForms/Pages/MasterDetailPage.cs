using System;


namespace Acr.XamForms {

    public class MasterDetailPage : Xamarin.Forms.MasterDetailPage {
        public bool BindChildLifecycle { get; set; }


        protected override void OnAppearing() {
            base.OnAppearing();
            (this.BindingContext as IViewModelLifecycle)?.OnActivate();
            if (this.BindChildLifecycle) {
                (this.Master.BindingContext as IViewModelLifecycle)?.OnActivate();
                (this.Detail.BindingContext as IViewModelLifecycle)?.OnActivate();
            }
        }


        protected override void OnDisappearing() {
            base.OnDisappearing();
            (this.BindingContext as IViewModelLifecycle)?.OnDeactivate();
            if (this.BindChildLifecycle) {
                (this.Master.BindingContext as IViewModelLifecycle)?.OnDeactivate();
                (this.Detail.BindingContext as IViewModelLifecycle)?.OnDeactivate();
            }
        }
    }
}