using System;
using Xamarin.Forms;
using System.Windows.Input;


namespace Acr.XamForms.Controls {

	public class AcrListView : ListView {
		public static BindableProperty ItemClickCommandProperty = BindableProperty.Create<AcrListView, ICommand>(x => x.ItemClickCommand, null);


		public AcrListView() {
			this.ItemTapped += this.OnItemTapped;
			this.ItemAppearing += this.OnItemAppearing;
			this.ItemDisappearing += this.OnItemDisappearing;
		}


		protected virtual void OnItemAppearing(object sender, ItemVisibilityEventArgs e)	{
			var vm = e.Item as IViewModelLifecycle;
			if (vm != null)
				vm.OnActivate();
		}


		private void OnItemDisappearing(object sender, ItemVisibilityEventArgs e)	{
			var vm = e.Item as IViewModelLifecycle;
			if (vm != null)
				vm.OnDeactivate();
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