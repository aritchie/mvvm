using System;


namespace Acr {

    public interface IViewModelLifecycle {
        bool IsStarted { get; }
        bool IsActive { get; }

        void OnStart();
        void OnActivate();
        void OnDeactivate();
    }
}
