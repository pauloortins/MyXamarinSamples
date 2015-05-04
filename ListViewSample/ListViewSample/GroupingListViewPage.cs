using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ListViewSample
{
	public class GroupingListViewPage : ContentPage
	{		
		class State : ObservableCollection<City>
		{
			public State(string name)
			{
				Name = name;
			}

			public string Name {
				get;
				set;
			}
		}

		class City
		{
			public string Name {
				get;
				set;
			}
		}

		public GroupingListViewPage ()
		{
			Padding = new Thickness (20);

			var states = new List<State> () {
				new State("FL") 
				{
					new City() {Name = "Miami"},
					new City() {Name = "Orlando"},
				},
				new State("CA") 
				{					
					new City() {Name = "Los Angeles"},
					new City() {Name = "San Francisco"},
				},
				new State("TX") 
				{					
					new City() {Name = "Houston"},
					new City() {Name = "Austin"},
				},
				new State("NY") 
				{					
					new City() {Name = "New York City"},
				}
			};

			var dataTemplate = new DataTemplate (typeof(TextCell));
			dataTemplate.SetBinding (TextCell.TextProperty, "Name");

			var listView = new ListView () {
				IsGroupingEnabled = true,
				GroupDisplayBinding = new Binding("Name"),
				GroupShortNameBinding = new Binding("Name"),
				ItemsSource = states,
				ItemTemplate = dataTemplate
			};

			Content = listView;
		}
	}
}

