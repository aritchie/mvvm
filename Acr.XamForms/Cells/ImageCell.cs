﻿using System;


namespace Acr.XamForms {

    public class ImageCell : Xamarin.Forms.ImageCell {

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