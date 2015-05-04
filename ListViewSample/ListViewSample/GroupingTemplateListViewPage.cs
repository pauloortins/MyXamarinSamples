using System;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace ListViewSample
{
	public class GroupingTemplateListViewPage : ContentPage
	{		
		class State : ObservableCollection<City>
		{
			public State(string name, string icon)
			{
				Name = name;
				Icon = icon;
			}

			public string Name {
				get;
				set;
			}

			public string Icon {
				get;
				set;
			}
		}

		class StateTemplate : ViewCell
		{
			public StateTemplate()
			{
				var text = new Label();
				text.SetBinding(Label.TextProperty, "Name");

				var icon = new Image() {
					WidthRequest = 25,
					HeightRequest = 25
				};
				icon.SetBinding(Image.SourceProperty, "Icon");

				var view = new StackLayout() {
					Orientation = StackOrientation.Horizontal,
					Children = {
						icon,
						text
					}
				};

				Height = 30;
				View = view;
			}
		}

		class City
		{
			public string Name {
				get;
				set;
			}
		}			

		public GroupingTemplateListViewPage ()
		{
			Padding = new Thickness (20);

			var states = new List<State> () {
				new State("FL", "fl.jpg") 
				{
					new City() {Name = "Miami"},
					new City() {Name = "Orlando"},
				},
				new State("CA", "ca.jpeg") 
				{					
					new City() {Name = "Los Angeles"},
					new City() {Name = "San Francisco"},
				},
				new State("TX", "tx.jpg") 
				{					
					new City() {Name = "Houston"},
					new City() {Name = "Austin"},
				},
				new State("NY", "ny.jpg") 
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
				ItemTemplate = dataTemplate,
				GroupHeaderTemplate = new DataTemplate(typeof(StateTemplate)),
				HasUnevenRows = true
			};					

			Content = listView;
		}
	}
}

