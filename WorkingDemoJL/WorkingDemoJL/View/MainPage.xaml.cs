using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingDemoJL.View;
using Xamarin.Forms;

namespace WorkingDemoJL
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    private void Button_OnClicked(object sender, EventArgs e)
	    {
	        Navigation.PushAsync(new Page2());
	    }
	}
}
