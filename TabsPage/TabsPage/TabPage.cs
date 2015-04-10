using System;
using Xamarin.Forms;

namespace TabsPage
{
	public class TabPage : TabbedPage
	{
		public TabPage ()
		{
			this.Children.Add (new BluePage ());
			this.Children.Add (new RedPage ());
		}
	}
}

