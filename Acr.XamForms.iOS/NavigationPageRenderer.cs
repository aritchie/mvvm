using System;
using Acr.XamForms.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Acr.XamForms.NavigationPage), typeof(NavigationPageRenderer))]


namespace Acr.XamForms.iOS
{
    public class NavigationPageRenderer : NavigationRenderer
    {
        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

			var page = this.Element as Page;
            if (page == null)
                return;

            var title = Xamarin.Forms.NavigationPage.GetBackButtonTitle(this.Element);
            this.NavigationItem.SetLeftBarButtonItem(new UIBarButtonItem(title, UIBarButtonItemStyle.Plain, (sender, args) =>
            {
                var goBack = page.SendBackButtonPressed();
                if (goBack)
                    this.NavigationController.PopViewController(true);

            }), true);
        }
    }
}