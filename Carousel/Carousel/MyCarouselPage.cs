using System;
using Xamarin.Forms;

namespace Carousel
{
	public class MyCarouselPage : CarouselPage
	{
		public MyCarouselPage ()
		{
			this.Children.Add (new BluePage ());
			this.Children.Add (new RedPage ());
			this.Children.Add (new YellowPage ());
			this.Children.Add (new GreenPage ());
		}
	}
}

