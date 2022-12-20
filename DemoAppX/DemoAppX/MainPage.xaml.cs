using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoAppX
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new
            {
                TextTest = "Login",
                RadiusTest = 45.0f,
                GradientStyle = "linear-gradient(19deg, rgba(189,65,65,1) 33%, rgba(237,18,18,1) 80%, rgba(255,0,0,1) 100%)",
                Command = new Command(() =>
                {
                    DisplayAlert("Test", "Testing command", "Ok");
                })
            };
        }
        async void Ir(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageTipo());
        }
    }
}
