using System;
using Xamarin.Forms;
using System.Windows.Input;


namespace Acr.XamForms {

	public class ListView : Xamarin.Forms.ListView {
		public static BindableProperty ItemClickCommandProperty = BindableProperty.Create<ListView, ICommand>(x => x.ItemClickCommand, null);


		public ListView() {
			this.ItemTapped += this.OnItemTapped;
			this.ItemAppearing += this.OnItemAppearing;
			this.ItemDisappearing += this.OnItemDisappearing;
		}


		protected virtual void OnItemAppearing(object sender, ItemVisibilityEventArgs e)	{
			(e.Item as IViewModelLifecycle)?.OnActivate();
		}


		protected virtual void OnItemDisappearing(object sender, ItemVisibilityEventArgs e)	{
			(e.Item as IViewModelLifecycle)?.OnDeactivate();
		}


		public ICommand ItemClickCommand {
			get { return (ICommand)this.GetValue(ItemClickCommandProperty); }
			set { this.SetValue(ItemClickCommandProperty, value); }
		}


		private void OnItemTapped(object sender, ItemTappedEventArgs e) {
			if (e.Item != null && this.ItemClickCommand != null && this.ItemClickCommand.CanExecute(e)) {
				this.ItemClickCommand.Execute(e.Item);
				this.SelectedItem = null;
			}
		}
	}
}