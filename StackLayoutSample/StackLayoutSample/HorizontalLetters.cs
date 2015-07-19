using System;
using Xamarin.Forms;

namespace StackLayoutSample
{
	public class HorizontalLetters : ContentPage
	{
		public HorizontalLetters ()
		{
			Padding = new Thickness (0, Device.OnPlatform (20, 0, 0));
			Content = new StackLayout () {					
				Orientation = StackOrientation.Horizontal,
				Children = {
					new Label() {Text="A", FontSize = 30},
					new Label() {Text="B", FontSize = 30},
					new Label() {Text="C", FontSize = 30},
					new Label() {Text="D", FontSize = 30},
					new Label() {Text="E", FontSize = 30}
				}
			};
		}
	}
}

