using System;


namespace Acr
{

    public abstract class LifecycleViewModel : ViewModel, IViewModelLifecycle
    {
        public bool IsStarted { get; private set; }
        public bool IsActive { get; private set; }


        public virtual void OnStart() { }


        public virtual void OnActivate()
        {
            this.IsActive = true;
            if (!this.IsStarted)
            {
                this.OnStart();
                this.IsStarted = true;
            }
        }


        public virtual void OnDeactivate()
        {
            this.IsActive = false;
        }


        public virtual bool OnBack()
        {
            return true;
        }
    }
}