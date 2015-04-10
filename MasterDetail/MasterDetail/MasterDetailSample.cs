using System;
using Xamarin.Forms;

namespace MasterDetail
{
	public class MasterDetailSample : MasterDetailPage
	{
		public MasterDetailSample ()
		{
			Master = new ContentPage () { BackgroundColor = Color.Red };
			Detail = new ContentPage () { BackgroundColor = Color.Blue};
		}
	}
}

