using System;
using Xamarin.Forms;
using AngusInsights.ViewModels;
using System.Windows.Input;


namespace Acr.XamForms.Controls {

	public class AcrListView : AcrListView {
		public static BindableProperty ItemClickCommandProperty = BindableProperty.Create<AcrListView, ICommand>(x => x.ItemClickCommand, null);


		public AcrListView() {
			this.ItemTapped += this.OnItemTapped;
			this.ItemAppearing += this.OnItemAppearing;
			this.ItemDisappearing += this.OnItemDisappearing;
		}


		protected virtual void OnItemAppearing (object sender, ItemVisibilityEventArgs e)	{
			var vm = e.Item as IViewModel;
			if (vm != null)
				vm.OnAppearing();
		}


		private void OnItemDisappearing(object sender, ItemVisibilityEventArgs e)	{
			var vm = e.Item as IViewModel;
			if (vm != null)
				vm.OnDisappearing();
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