using System;

namespace Places
{
	public class Place
	{
		public string Name {
			get;
			set;
		}

		public string Icon {
			get;
			set;
		}

		public string Address {
			get;
			set;
		}

		public Place (string name, string icon, string address)
		{
			Name = name;
			Icon = icon;
			Address = address;
		}
	}
}

