using System;
using Xamarin.Forms;

namespace LorenIpsumPage
{
	public class FirstPage : ContentPage
	{
		public FirstPage ()
		{
			Content = new Label {
				XAlign = TextAlignment.Center,
				Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
				"Nulla finibus, quam in elementum mattis, ipsum velit bibendum nisi, " +
				"ut feugiat ligula mi at lectus. Cras pretium elit a tortor accumsan " +
				"sagittis. Nunc vulputate libero sed sapien fermentum, eget condimentum " +
				"elit volutpat. Phasellus tincidunt sem mattis maximus auctor. Nunc congue " +
				"sodales urna, vel venenatis tortor tristique at. Vestibulum volutpat " +
				"sollicitudin mi vitae viverra. Nunc sollicitudin, nisl ac placerat congue, " +
				"erat libero fringilla ante, at sodales risus leo ut lorem."
			};
		}
	}
}

