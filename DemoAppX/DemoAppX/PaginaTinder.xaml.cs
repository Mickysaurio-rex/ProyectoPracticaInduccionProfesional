using MLToolkit.Forms.SwipeCardView.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoAppX
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	[DesignTimeVisible(false)]
	public partial class PaginaTinder : ContentPage
	{
		public ObservableCollection<UserProfile> _Profiles = new ObservableCollection<UserProfile>();
		public PaginaTinder()
		{
			InitializeComponent();
			CardBinding();
			BindingContext = this;
            UserProfile usuario = Profiles.FirstOrDefault();
 		}

		public void CardBinding()
		{
			Profiles.Add(new UserProfile() { Name = "Max", Age = "5", Photo = "P1.jpg", Descripcion = "Perrito Jugueton con muchas ganas de conocer a alguien" });
            Profiles.Add(new UserProfile() { Name = "Lucas", Age = "3", Photo = "P2.jpg", Descripcion = "Perrito Jugueton con muchas ganas de conocer a alguien" });
            Profiles.Add(new UserProfile() { Name = "Spike", Age = "2", Photo = "P3.jpg", Descripcion = "Perrito Jugueton con muchas ganas de conocer a alguien" });
            Profiles.Add(new UserProfile() { Name = "Mori", Age = "3", Photo = "P4.jpg", Descripcion = "Perrito Jugueton con muchas ganas de conocer a alguien" });
            Profiles.Add(new UserProfile() { Name = "Mara", Age = "3", Photo = "P10.jpg", Descripcion = "Perrito Jugueton con muchas ganas de conocer a alguien" });
            Profiles.Add(new UserProfile() { Name = "Bolita", Age = "4", Photo = "P6.jpg", Descripcion = "Perrito Jugueton con muchas ganas de conocer a alguien" });
            Profiles.Add(new UserProfile() { Name = "Negra", Age = "2", Photo = "P7.jpg", Descripcion = "Perrito Jugueton con muchas ganas de conocer a alguien" });
            Profiles.Add(new UserProfile() { Name = "Tomas", Age = "1", Photo = "P8.jpg", Descripcion = "Perrito Jugueton con muchas ganas de conocer a alguien" });
            Profiles.Add(new UserProfile() { Name = "Bolt", Age = "6", Photo = "P9.jpg", Descripcion = "Perrito Jugueton con muchas ganas de conocer a alguien" });
            

        }
		public ObservableCollection<UserProfile> Profiles
		{
			get => _Profiles;
			set
			{
				_Profiles= value;
			}
		}

		public class UserProfile
		{
			public string Name { get; set; }
            public string Age { get; set; }
            public string Photo { get; set; }
            public string Descripcion { get; set; } 
            
        }

        private void nopeButton_Clicked(object sender, EventArgs e)
        {
            SwipeView1.InvokeSwipe((MLToolkit.Forms.SwipeCardView.Core.SwipeCardDirection)MLToolkit.Forms.SwipeCardView.Core.SwipeCardDirection.Left);
        }

        private void superLikeButton_Clicked(object sender, EventArgs e)
        {
            SwipeView1.InvokeSwipe((MLToolkit.Forms.SwipeCardView.Core.SwipeCardDirection)MLToolkit.Forms.SwipeCardView.Core.SwipeCardDirection.Up);
        }

        private void likeButton_Clicked(object sender, EventArgs e)
        {
            SwipeView1.InvokeSwipe((MLToolkit.Forms.SwipeCardView.Core.SwipeCardDirection)MLToolkit.Forms.SwipeCardView.Core.SwipeCardDirection.Right);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string nombre = Profiles.FirstOrDefault().Name;
            string edad = Profiles.FirstOrDefault().Age;    
            string descripcion = Profiles.FirstOrDefault().Descripcion;
            await Navigation.PushAsync(new PaginaInformacion(nombre, edad, descripcion));
        }
    }
}