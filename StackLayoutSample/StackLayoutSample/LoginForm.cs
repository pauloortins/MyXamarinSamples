using System;
using Xamarin.Forms;

namespace StackLayoutSample
{
	public class LoginForm : ContentPage
	{
		public LoginForm ()
		{
			Padding = new Thickness (5, Device.OnPlatform (20, 0, 0), 5, 0);
			
			var userLabel = new Label () {
				Text = "User:", 
				WidthRequest = 100
			};
			var userEntry = new Entry () {
				HorizontalOptions = LayoutOptions.FillAndExpand
			};
			var userStack = new StackLayout () {
				Orientation = StackOrientation.Horizontal,
				Children = {userLabel, userEntry}
			};

			var passwordLabel = new Label () {
				Text = "Password:", 
				WidthRequest = 100
			};
			var passwordEntry = new Entry () {
				HorizontalOptions = LayoutOptions.FillAndExpand, 
				IsPassword = true 
			};
			var passwordStack = new StackLayout () {
				Orientation = StackOrientation.Horizontal,
				Children = {passwordLabel, passwordEntry}
			};

			var loginButton = new Button () {Text = "Login"};

			var formStack = new StackLayout () {
				Children = {
					userStack,
					passwordStack,
					loginButton
				}
			};

			Content = formStack;
		}
	}
}

