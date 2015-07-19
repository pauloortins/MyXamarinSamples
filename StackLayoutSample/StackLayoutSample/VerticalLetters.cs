using System;
using Xamarin.Forms;

namespace StackLayoutSample
{
	public class VerticalLetters : ContentPage
	{
		public VerticalLetters ()
		{
			Padding = new Thickness (0, Device.OnPlatform (20, 0, 0));
			Content = new StackLayout () {					
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

