using System;
using Xamarin.Forms;

namespace RedBlueNavigation
{
	public abstract class ColorPage : ContentPage
	{
		private StackLayout _pages;

		public ColorPage ()
		{
			_pages = new StackLayout ();

			// Create Buttons
			var redButton = new Button () {Text = "Push Red Page"};
			redButton.Clicked += async (object sender, EventArgs e) => 
			{
				await this.Navigation.PushAsync(new RedPage());
			};

			var blueButton = new Button () {Text = "Push Blue Page"};
			blueButton.Clicked += async (object sender, EventArgs e) => 
			{
				await this.Navigation.PushAsync(new BluePage());
			};

			var backButton = new Button () {Text = "Back"};
			backButton.Clicked += async (object sender, EventArgs e) => 
			{
				await this.Navigation.PopAsync();
			};

			var rootButton = new Button () {Text = "Back to Root"};
			rootButton.Clicked += async (object sender, EventArgs e) => 
			{
				await this.Navigation.PopToRootAsync();
			};

			// Create Content
			Content = new StackLayout () 
			{
				Children = {
					redButton,
					blueButton,
					backButton,
					rootButton,
					_pages
				}	
			};
		}
			
		protected override void OnAppearing ()
		{
			// Override default OnAppearing and write NavigationStackContent
			_pages.Children.Clear ();
			foreach (var page in this.Navigation.NavigationStack) {
				_pages.Children.Add (
					new Label () 
					{
						Text = page.GetType().ToString()
					}
				);
			}
		}
	}
}

