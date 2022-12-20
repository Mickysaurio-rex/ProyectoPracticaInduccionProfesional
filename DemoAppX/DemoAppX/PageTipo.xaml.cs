using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoAppX
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageTipo : ContentPage
	{
		public PageTipo ()
		{
			InitializeComponent ();
		}
        async void Ir(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageRegistro());
        }
    }

}