using System;
using Xamarin.Forms;

namespace GridSample
{
	public class GridPage3 : ContentPage
	{
		public GridPage3 ()
		{
			Padding = new Thickness (0, Device.OnPlatform (20, 0, 0), 0, 0);

			var grid = new Grid ();

			var aqua = new Label () {Text = "(0,0)", BackgroundColor=Color.Aqua};
			grid.Children.Add (aqua, 0, 0);
			Grid.SetColumnSpan (aqua, 2);

			var gray = new Label () { Text = "(1,0)", BackgroundColor = Color.Gray };
			grid.Children.Add (gray, 0, 1);
			Grid.SetColumnSpan (gray, 2);

			var yellow = new Label () { Text = "(0,2)", BackgroundColor = Color.Yellow };
			grid.Children.Add (yellow, 0, 2);
			Grid.SetRowSpan (yellow, 2);

			var pink = new Label () { Text = "(2,0)", BackgroundColor = Color.Pink };
			grid.Children.Add (pink, 0, 2);
			Grid.SetColumnSpan (pink, 3);

			Content = grid;
		}
	}
}

