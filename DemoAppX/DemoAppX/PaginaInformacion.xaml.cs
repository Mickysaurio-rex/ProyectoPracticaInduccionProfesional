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
    public partial class PaginaInformacion : ContentPage
    {
        public PaginaInformacion(string nombre, string edad, string descripcion)
        {
            InitializeComponent();
            LabelNombre.Text = nombre ;
            LabelEdad.Text = edad;
            LabelDescripcion.Text = descripcion;
        }

        
    }
}