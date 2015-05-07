using System;
using Xamarin.Forms;

namespace Places
{
	public class MasterDetail : MasterDetailPage
	{
		public MasterDetail ()
		{
			var menuPage = new MenuPage ();
			menuPage.OnMenuSelect = (categoryPage) => {
				Detail = new NavigationPage(categoryPage);
				IsPresented = false;
			};

			Master = menuPage;

			Detail = new NavigationPage(new FoodCategoryPage ());

			MasterBehavior = MasterBehavior.Split;
		}
	}
}

