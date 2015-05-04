using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ListViewSample
{
	public class EventsListViewPage : ContentPage
	{
		public EventsListViewPage ()
		{
			Padding = new Thickness (20);
			
			var cities = new List<string> () { "New York", "Los Angeles", "Miami"};

			var listView = new ListView () {
				ItemsSource = cities	
			};

			listView.ItemTapped += (object sender, ItemTappedEventArgs e) => {
				DisplayAlert("ItemTapped", e.Item.ToString(), "Ok");
			};

			listView.ItemSelected += (object sender, SelectedItemChangedEventArgs e) => {
				DisplayAlert("ItemSelected", e.SelectedItem.ToString(), "Ok");
			};

			Content = listView;
		}
	}
}

