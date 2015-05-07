using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace Places
{
	public class FoodCategoryPage : ContentPage
	{
		public FoodCategoryPage ()
		{
			Title = "Food";

			Padding = new Thickness (10, 20);

			var places = new List<Place> () 
			{
				new Place("McDonalds", "mcdonalds.png", "1010 S McKenzie St Foley, AL"),
				new Place("Burger King", "burgerKing.png", "910 S McKenzie St Foley AL"),
				new Place("Apple Bees", "appleBees.png", "2409 S McKenzie St, Foley, AL"),
				new Place("Taco Bell", "tacoBell.jpg", "1165 S McKenzie St, Foley, AL"),
				new Place("Subway", "subway.jpg", "610 S McKenzie St Foley, AL")
			};

			var imageTemplate = new DataTemplate (typeof(ImageCell));
			imageTemplate.SetBinding (ImageCell.TextProperty, "Name");
			imageTemplate.SetBinding (ImageCell.ImageSourceProperty, "Icon");
			imageTemplate.SetBinding (ImageCell.DetailProperty, "Address");

			var listView = new ListView () 
			{
				ItemsSource = places,
				ItemTemplate = imageTemplate
			};

			Content = listView;
		}
	}
}

