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
    public partial class Resumen : ContentPage
    {
        public Resumen(String username, String name, float amount)
        {
            InitializeComponent();
            lblWelcome.Text = "Bienvenido " + username;
            lblName.Text = name;
            lblToPay.Text = "$"+ amount.ToString();
        }
    }
}