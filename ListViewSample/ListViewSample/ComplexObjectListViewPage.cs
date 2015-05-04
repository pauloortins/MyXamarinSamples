using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace ListViewSample
{
	public class ComplexObjectListViewPage : ContentPage
	{
		class City
		{
			public string Name {
				get;
				set;
			}

			public string State {
				get;
				set;
			}
		}

		public ComplexObjectListViewPage ()
		{			
			var cities = new List<City> () {
				new City() {State = "FL", Name = "Miami"},
				new City() {State = "CA", Name = "San Francisco"},
				new City() {State = "CA", Name = "Los Angeles"},
				new City() {State = "FL", Name = "Orlando"},
				new City() {State = "TX", Name = "Houston"},
				new City() {State = "NY", Name = "New York City"},
			};

			var dataTemplate = new DataTemplate (typeof(TextCell));
			dataTemplate.SetBinding (TextCell.TextProperty, "Name");

			var listView = new ListView () {
				ItemsSource = cities,
				ItemTemplate = dataTemplate
			};

			Content = listView;
		}
	}
}

