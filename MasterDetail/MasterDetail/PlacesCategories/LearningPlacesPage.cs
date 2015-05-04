using System;
using Xamarin.Forms;

namespace MasterDetail
{
	public class LearningPlacesPage : ContentPage
	{
		public LearningPlacesPage ()
		{
			Title = "learning places";
			Content = new Label () {
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				Text = "Learning"
			};
		}
	}
}

