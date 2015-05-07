using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace Places
{
	public class SportsCategoryPage : ContentPage
	{
		public SportsCategoryPage ()
		{
			Title = "Sports";

			Padding = new Thickness (10, 20);

			var places = new List<Place> () 
			{
				new Place("The Gulf Bowl", "gulfBowl.jpg", "2881 S Juniper St, Foley, AL"),
				new Place("Foley Sports Complex", "foleySportsComplex.jpg", "998 W Section Ave, Foley, AL"),
				new Place("Swatters Sports Complex", "swattersSportsComplex.jpg", "21431 Co Rd 12 S Foley, AL")
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

