using System;
using System.Collections.Generic;
using Acr;


namespace Sample
{
    public class ListViewModel : LifecycleViewModel
    {
        public override void OnActivate()
        {
            base.OnActivate();
            this.List = new List<ListItem>
            {
                new ListItem
                {
                    Text = "Hi",
                    Detail = "This is a list example"
                },
                new ListItem
                {
                    Text = "By the way",
                    Detail = "Selection is disabled"
                }
            };
        }


        public override bool OnBack()
        {
            App
				.Current
                .MainPage
                .DisplayAlert("Blocked", "Navigation will not continue until you hit OK", null)
                .ContinueWith(async x =>
                {
                    await App.Current.MainPage.Navigation.PopAsync(true);
                });

            return false;
        }


        IList<ListItem> list;
        public IList<ListItem> List
        {
            get { return this.list; }
            private set
            {
                this.list = value;
                this.OnPropertyChanged();
            }
        }
    }
}
