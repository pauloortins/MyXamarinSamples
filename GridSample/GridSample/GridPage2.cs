using System;
using Xamarin.Forms;

namespace GridSample
{
	public class GridPage2 : ContentPage
	{
		public GridPage2()
		{
			Padding = new Thickness (0, Device.OnPlatform (20, 0, 0), 0, 0);

			var grid = new Grid ();

			// Columns 0 and 1 - Row 0		
			grid.Children.Add (new Label () {Text = "(0,0)", BackgroundColor=Color.Aqua}, 0, 2, 0, 1);

			// Columns 0 and 1 - Row 1
			grid.Children.Add (new Label () {Text = "(1,0)", BackgroundColor=Color.Gray}, 0, 2, 1, 2);

			// Column 2 - Rows 0 and 1
			grid.Children.Add (new Label () {Text = "(0,2)", BackgroundColor=Color.Yellow}, 2, 3, 0, 2);

			// Columns 0, 1 and 2 - Row 2
			grid.Children.Add (new Label () {Text = "(2,0)", BackgroundColor=Color.Pink}, 0, 3, 2, 3);

			Content = grid;
		}
	}
}

