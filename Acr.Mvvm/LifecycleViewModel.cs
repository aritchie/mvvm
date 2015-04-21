using System;


namespace Acr {

    public abstract class LifecycleViewModel : ViewModel, IViewModelLifecycle {

        public virtual void OnActivate() {}
        public virtual void OnDeactivate() {}
    }
}
