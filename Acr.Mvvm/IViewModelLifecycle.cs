using System;


namespace Acr {

    public interface IViewModelLifecycle {

        void OnActivate();
        void OnDeactivate();
    }
}
