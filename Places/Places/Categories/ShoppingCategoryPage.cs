using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace Places
{
	public class ShoppingCategoryPage : ContentPage
	{
		public ShoppingCategoryPage ()
		{
			Title = "Shopping";

			Padding = new Thickness (10, 20);

			var places = new List<Place> () 
			{
				new Place("Walmart", "walmart.jpeg", "2200 S McKenzie St, Foley"),
				new Place("Tanger Outlet Center", "tanger.jpg", "2601 S McKenzie St, Ste 466, Foley, AL"),
				new Place("Radio Shack", "radioShack.jpg", "1190 S Mckensie, Foley, AL")
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

