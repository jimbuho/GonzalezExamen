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
    public partial class Registro : ContentPage
    {
        static private float PRICE = 1800;
        private String username;
        private float montly;
        private float amount;

        public Registro(String username)
        {
            InitializeComponent();
            lblWelcome.Text = "Bienvenido " + username;
            this.username = username;
        }

        private void btnCalc_Clicked(object sender, EventArgs e)
        {
            if (txtAmount.Text != null)
            {
                amount = float.Parse(txtAmount.Text);
                if (amount <= PRICE)
                {
                    float difference = (float)(PRICE - amount);
                    this.montly = (float)(difference / 3 * 1.05);
                    lblMonthlyFee.Text = "Pago Mensual: $" + montly.ToString();
                }
                else
                {
                    DisplayAlert("Atencion", "Valor de pago inicial no debe superar el precio total de "+PRICE, "Aceptar");
                }
            }
            else {
                DisplayAlert("Atencion", "Debe ingresar un pago inicial para calcular cuota", "Aceptar");
            }
        }
        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            float total = this.montly * 3 + this.amount;
            await Navigation.PushAsync(new Resumen(this.username, txtName.Text, total));
        }

    }
}