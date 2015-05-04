using System;
using Xamarin.Forms;

namespace MasterDetail
{
	public class ShoppingPlacesPage : ContentPage
	{
		public ShoppingPlacesPage ()
		{
			Title = "shopping places";
			Content = new Label () {
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				Text = "Shopping"
			};
		}
	}
}

