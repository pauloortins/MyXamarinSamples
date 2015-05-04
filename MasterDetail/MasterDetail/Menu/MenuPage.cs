using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace MasterDetail
{
	public class MenuPage : ContentPage
	{		
		public Action<Page> OnMenuTap;

		public MenuPage ()
		{
			Icon = "masterIcon.png";
			Title = "Menu";
			BackgroundColor = Color.FromHex ("444444");

			Padding = new Thickness (10, 20);

			var layout = new StackLayout { 
				Spacing = 15, 
				VerticalOptions = LayoutOptions.FillAndExpand
			};

			var header = new StackLayout () {
				Orientation = StackOrientation.Horizontal
			};

			header.Children.Add (new Image () {
				Source = "masterIcon.png",
				WidthRequest = 25,
				HeightRequest = 25
			});
					
			header.Children.Add (new Label () {
				Text = "places",
				TextColor = Color.FromHex ("dddddd"),
				VerticalOptions = LayoutOptions.CenterAndExpand
			});

			layout.Children.Add (header);

			var foodPlaces = new Label () {
				Text = "Food",
				TextColor = Color.FromHex ("dddddd")
			};
			foodPlaces.GestureRecognizers.Add (new TapGestureRecognizer ((view) => OnMenuTap(new FoodPlacesPage())));
			layout.Children.Add (foodPlaces);

			var shoppingPlaces = new Label () {
				Text = "Shopping",
				TextColor = Color.FromHex ("dddddd")
			};
			shoppingPlaces.GestureRecognizers.Add (new TapGestureRecognizer ((view) => OnMenuTap(new ShoppingPlacesPage())));
			layout.Children.Add (shoppingPlaces);

			var learningPlaces = new Label () {
				Text = "Learning",
				TextColor = Color.FromHex ("dddddd")
			};
			learningPlaces.GestureRecognizers.Add (new TapGestureRecognizer ((view) => OnMenuTap(new LearningPlacesPage())));
			layout.Children.Add (learningPlaces);

			Content = layout;
		}
	}
}

