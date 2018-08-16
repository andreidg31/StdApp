using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StandardApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void button_Pressed(object sender, EventArgs e)
        {
            Page page = (Page)Activator.CreateInstance(typeof(HelloPage));
            //await Navigation.PushModalAsync(page);
            await Navigation.PushAsync(page);
        }

        private async void button2_Pressed(object sender, EventArgs e)
        {
            Page page = (Page)Activator.CreateInstance(typeof(XamlAndCode));
            //await Navigation.PushModalAsync(page);
            await Navigation.PushAsync(page);
        }

        private async void button1_Pressed(object sender, EventArgs e)
        {
            Page page = (Page)Activator.CreateInstance(typeof(AbsoluteDemo));
            //await Navigation.PushModalAsync(page);
            await Navigation.PushAsync(page);
        }

        private async void button3_Pressed(object sender, EventArgs e)
        {
            Page page = (Page)Activator.CreateInstance(typeof(GridDemo));
            //await Navigation.PushModalAsync(page);
            await Navigation.PushAsync(page);
        }
    }
}
