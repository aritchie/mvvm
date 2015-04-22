using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace Acr {

    public abstract class ViewModel : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }


        protected virtual bool SetProperty<T>(ref T property, T value, [CallerMemberName] string propertyName = null) {
            if (Object.Equals(property, value))
                return false;

            property = value;
            this.OnPropertyChanged(propertyName);
            return true;
        }
    }
}
/*
		protected bool IsStarted { get; private set; }
		protected IMwlServices Services { get; private set; }

		public event PropertyChangedEventHandler PropertyChanged;


		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
			if (this.PropertyChanged != null)
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}


		protected virtual bool SetProperty<T>(ref T property, T value, [CallerMemberName] string propertyName = null) {
			if (Object.Equals(property, value))
				return false;

			property = value;
			this.OnPropertyChanged(propertyName);
			return true;
		}


		protected ViewModel(IMwlServices services) {
			this.Services = services;
		}


		private string title;
		public string Title {
			get { return this.title; }
			set { this.SetProperty(ref this.title, value); }
		}


		public bool IsVisible { get; private set; }


		protected virtual void OnStart() {}


		public virtual void OnAppearing() {
			this.IsVisible = true;
			if (!this.IsStarted) {
				this.OnStart();
				this.IsStarted = true;
			}
		}


		public virtual void OnDisappearing() {
			this.IsVisible = false;
		}


		protected virtual void OnError(Exception exception, string errorMsg = null) {
			Debug.WriteLine("[ERROR] - " + exception);
			this.Services.Dialogs.Alert(errorMsg ?? "There was an error with your request");
		}*/