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
    public partial class PageRegistro : ContentPage
    {
        public PageRegistro()
        {
            InitializeComponent();
        }
        async void Ir(object sender, EventArgs e)
        {
          if(Nombre.Text != null && Peso.Text != null && Tamano != null && Raza.Text != null && Dia.Text != null && Mes.Text 
                != null && Edad.Text != null)
            {
                await Navigation.PushAsync(new PaginaTinder());
            }
            
        }

        private void DisplayAlert(string v)
        {
            throw new NotImplementedException();
        }
    }
}