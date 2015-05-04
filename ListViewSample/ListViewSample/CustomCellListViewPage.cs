using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace ListViewSample
{
	public class CustomCellListViewPage : ContentPage
	{
		class CustomCell : ViewCell
		{
			public CustomCell()
			{
				var stateLabel = new Label () 
				{
					Text = "State:"
				};

				var stateText = new Label ();
				stateText.SetBinding (Label.TextProperty, "State");

				var cityLabel = new Label () 
				{
					Text = "City:"	
				};

				var cityText = new Label ();
				cityText.SetBinding (Label.TextProperty, "Name");

				var view = new StackLayout () {
					Orientation = StackOrientation.Horizontal,
					Children = 
					{
						stateLabel,
						stateText,
						cityLabel,
						cityText
					}
				};

				View = view;
			}
		}

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

		public CustomCellListViewPage ()
		{
			Padding = new Thickness (20);

			var cities = new List<City> () {
				new City() {State = "FL", Name = "Miami"},
				new City() {State = "CA", Name = "San Francisco"},
				new City() {State = "CA", Name = "Los Angeles"},
				new City() {State = "FL", Name = "Orlando"},
				new City() {State = "TX", Name = "Houston"},
				new City() {State = "NY", Name = "New York City"},
			};

			var dataTemplate = new DataTemplate (typeof(CustomCell));

			var listView = new ListView () {
				ItemsSource = cities,
				ItemTemplate = dataTemplate
			};

			Content = listView;
		}
	}
}

