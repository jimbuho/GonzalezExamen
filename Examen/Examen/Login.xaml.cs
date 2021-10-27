using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            if (txtUser.Text == "estudiante2021" && txtPass.Text == "uisrael2021")
            {
                await Navigation.PushAsync(new Registro(txtUser.Text));
            }
            else
            {
                await DisplayAlert("Atencion", "Usuario o password invalidos", "Aceptar");
            }
        }
    }
}