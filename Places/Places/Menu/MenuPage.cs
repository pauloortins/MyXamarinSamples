using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace Places
{
	public class MenuPage : ContentPage
	{
		public Action<ContentPage> OnMenuSelect {
			get;
			set;
		}

		public MenuPage ()
		{
			Title = "Menu";
			Icon = "menu.png";

			Padding = new Thickness (10, 20);

			var categories = new List<Category> () {
				new Category("Food", () => new FoodCategoryPage()),
				new Category("Shopping", () => new ShoppingCategoryPage()),
				new Category("Sports", () => new SportsCategoryPage())
			};

			var dataTemplate = new DataTemplate (typeof(TextCell));
			dataTemplate.SetBinding (TextCell.TextProperty, "Name");

			var listView = new ListView () {
				ItemsSource = categories,
				ItemTemplate = dataTemplate
			};

			listView.ItemSelected += (object sender, SelectedItemChangedEventArgs e) => {
				if (OnMenuSelect != null)
				{
					var category = (Category) e.SelectedItem;
					var categoryPage = category.PageFn();
					OnMenuSelect(categoryPage);
				}				
			};


			Content = listView;
		}
	}
}

