using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace ListViewSample
{
	public class TextListViewPage : ContentPage
	{
		public TextListViewPage ()
		{
			var cities = new List<string> () {
				"Miami",
				"San Francisco",
				"Los Angeles",
				"Orlando",
				"Houston",
				"New York City"
			};

			var listView = new ListView () {
				ItemsSource = cities
			};

			Content = listView;
		}
	}
}

