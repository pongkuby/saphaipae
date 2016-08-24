using System;
using Xamarin.Forms;

namespace Saphaipae
{
	public class Review
	{
		public string Title { get; set; }
		public ImageSource ImageSource { get; set; }
		public string ImageUrl
		{
			get { return this.ImageSource.ToString(); }
			set
			{
				this.ImageSource = new UriImageSource()
				{
					Uri = new Uri(value)
				};
			}
		}
		public string SubTitle { get; set; }
		public string Detail { get; set; }
		public string Lat { get; set; }
		public string Long { get; set; }

		public Review()
		{
		}
	}
}

