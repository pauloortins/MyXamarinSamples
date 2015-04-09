using System;
using Xamarin.Forms;

namespace RainbowContentPage
{
	public class RainbowPage : ContentPage
	{
		public RainbowPage ()
		{
			Content = new StackLayout () {				
				Children = {
					new BoxView() {Color = Color.Red},
					new BoxView() {Color = Color.FromRgb(255, 102, 0)},
					new BoxView() {Color = Color.Yellow},
					new BoxView() {Color = Color.Green},
					new BoxView() {Color = Color.Blue},
					new BoxView() {Color = Color.FromRgb(111, 0, 255)},
					new BoxView() {Color = Color.FromRgb(159, 0, 255)}
				}	
			};
		}
	}
}

