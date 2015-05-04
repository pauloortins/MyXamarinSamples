using System;
using Xamarin.Forms;

namespace MasterDetail
{
	public class AlabamaPlacesPage : MasterDetailPage
	{
		public AlabamaPlacesPage ()
		{			
			var menuPage = new MenuPage ();
			menuPage.OnMenuTap = (page) => { 
				IsPresented = false;
				Detail = new NavigationPage (page);
			};

			Master = menuPage;
			Detail = new NavigationPage(new FoodPlacesPage ());
		}
	}
}

