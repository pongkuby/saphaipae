using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Saphaipae
{
	public partial class DetailPage : ContentPage
	{
		public Review Review{ get; set; }

		public DetailPage ()
		{
			InitializeComponent ();
		}

		public void setDetail (Review review)
		{
			this.Title = review.Title;
			this.DetailText.Text = review.Detail;
			this.DetailImage.Source = review.ImageSource;
		}

		public void getRoute (object sender, EventArgs e)
		{
			var routePage = new RoutePage () { 
				Review = this.Review
			};
			this.Navigation.PushAsync (routePage);
		}
	}
}
