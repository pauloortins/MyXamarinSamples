using System;
using Xamarin.Forms;

namespace MasterDetail
{
	public class FoodPlacesPage : ContentPage
	{
		public FoodPlacesPage ()
		{
			Title = "food places";
			Content = new Label () {
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				Text = "Food"
			};
		}
	}
}

