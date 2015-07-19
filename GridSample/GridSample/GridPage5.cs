using System;
using Xamarin.Forms;

namespace GridSample
{
	public class GridPage5 : ContentPage
	{
		public GridPage5 ()
		{
			Padding = new Thickness (0, Device.OnPlatform (20, 0, 0), 0, 0);
			var grid = new Grid ();

			grid.Children.Add (
				new Image() {
					Source= Device.OnPlatform("Icon-60@2x.png", "icon.png", "")
				}, 0, 0);

			grid.Children.Add (new Label () { Text = "40", BackgroundColor = Color.Yellow}, 0, 1);
			grid.Children.Add (new Label () { Text = "Remainder", BackgroundColor = Color.Pink}, 0, 2);

			grid.RowDefinitions.Add (new RowDefinition () 
				{
					Height = new GridLength(1, GridUnitType.Auto)
				});

			grid.RowDefinitions.Add (new RowDefinition () 
				{
					Height = new GridLength(40, GridUnitType.Absolute)
				});

			grid.RowDefinitions.Add (new RowDefinition () 
				{
					Height = new GridLength(1, GridUnitType.Star)
				});

			Content = grid;
		}
	}
}

