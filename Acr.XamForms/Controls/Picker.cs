using System;
using System.Collections;
using Xamarin.Forms;


namespace Acr.XamForms {

    public class Picker : Xamarin.Forms.Picker {
        public static BindableProperty ItemsSourceProperty = BindableProperty.Create<Picker, IEnumerable>(x => x.ItemsSource, null, BindingMode.TwoWay, null, OnItemsSourceChanged);
        public static BindableProperty SelectedItemProperty = BindableProperty.Create<Picker, object>(x => x.SelectedItem, null, BindingMode.TwoWay, null, OnSelectedItemChanged);


        public Picker() {
            this.SelectedIndexChanged += this.OnSelectedIndexChanged;
        }


        public IEnumerable ItemsSource {
            get { return (IEnumerable)this.GetValue(ItemsSourceProperty); }
            set { this.SetValue(ItemsSourceProperty, value); }
        }


        public object SelectedItem {
            get { return this.GetValue(SelectedItemProperty); }
            set { this.SetValue(SelectedItemProperty, value); }
        }


        private void OnSelectedIndexChanged(object sender, EventArgs eventArgs) {
            if (this.SelectedIndex < 0 || this.SelectedIndex > this.Items.Count - 1)
                this.SelectedItem = null;
            else
                this.SelectedItem = this.Items[this.SelectedIndex];
        }


        private static void OnItemsSourceChanged(BindableObject bindable, IEnumerable oldValue, IEnumerable newValue) {
            var picker = (Picker)bindable;
            picker.Items.Clear();
            if (newValue == null)
                return;

            foreach (var item in newValue)
                picker.Items.Add(item.ToString());
        }


        private static void OnSelectedItemChanged(BindableObject bindable, object oldValue, object newValue) {
            var picker = (Picker)bindable;
            if (newValue != null)
                picker.SelectedIndex = picker.Items.IndexOf(newValue.ToString());
        }
    }
}