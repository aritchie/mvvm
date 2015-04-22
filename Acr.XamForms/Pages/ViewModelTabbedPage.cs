//using System;
//using Xamarin.Forms;


//namespace Acr.XamForms.Pages {

//    public class ViewModelTabbedPage : TabbedPage {

//        protected override void OnCurrentPageChanged() {
//            base.OnCurrentPageChanged();

//            var vm = this.CurrentPage.BindingContext as IViewModelLifecycle;
//            if (vm == null) {
//                var cp = this.CurrentPage as ContentPage;
//                if (cp != null)
//                    vm = cp.BindingContext as IViewModelLifecycle;
//                else {
//                    var nav = this.CurrentPage as NavigationPage;
//                    if (nav != null)
//                        vm = nav.CurrentPage.BindingContext as IViewModelLifecycle;
//                }
//            }
//            if (vm != null)
//                vm.OnAppearing();
//        }
//    }
//}
