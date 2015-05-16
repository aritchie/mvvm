using System;


namespace Acr.XamForms {

    public static class Extensions {

        public static void TryViewModelActivate(this object obj) {
            var vm = obj as IViewModelLifecycle;
            if (vm != null)
                vm.OnActivate();
        }


        public static void TryViewModelDeactivate(this object obj) {
            var vm = obj as IViewModelLifecycle;
            if (vm != null)
                vm.OnDeactivate();
        }
    }
}
