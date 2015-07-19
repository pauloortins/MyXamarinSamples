using System;
using Xamarin.Forms;

namespace GridSample
{
	public class GridPage : ContentPage
	{
		public GridPage()
		{
			Padding = new Thickness (0, Device.OnPlatform (20, 0, 0), 0, 0);

			var grid = new Grid ();

			grid.Children.Add (new Label () {Text = "(0,0)", BackgroundColor=Color.Aqua}, 0, 0);
			grid.Children.Add (new Label () {Text = "(0,1)", BackgroundColor=Color.Gray}, 1, 0);
			grid.Children.Add (new Label () {Text = "(1,0)", BackgroundColor=Color.Yellow}, 0, 1);
			grid.Children.Add (new Label () {Text = "(1,0)", BackgroundColor=Color.Pink}, 1, 1);

			Content = grid;
		}
	}
}

