using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace wcuascotaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(String estudiante)
        {
            InitializeComponent();
            lblEstudiante.Text = "Usuario Conectado: " + estudiante;
        }

        private void btCalcular_Clicked(object sender, EventArgs e)
        {
            if (txtMonto.Text == "3000")
            {
                lblPago.Text = "0";
            }
            else if (!string.IsNullOrEmpty(txtMonto.Text))
            {
                int ValorCurso = 3000;
                double montoInicial = Convert.ToDouble(txtMonto.Text);
                double pagoMensual = (ValorCurso - montoInicial) / 3;
                double porcentaje = ValorCurso * 0.5;
                double pagoCalculado = Math.Truncate(((pagoMensual + porcentaje))*100)/100;
                lblPago.Text = pagoCalculado.ToString();
            }
            else
            {
                DisplayAlert("Mensaje", "Ingrese un monto", "Aceptar");
            }
            
        }

        private void btGuardar_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtMonto.Text) && !string.IsNullOrEmpty(lblPago.Text))
            {
                string estudiante = lblEstudiante.Text;
                string nombre = txtNombre.Text;
                double pago = Convert.ToDouble(lblPago.Text);
                double montoInicial = Convert.ToDouble(txtMonto.Text);
                DisplayAlert("Mensaje", "Datos Guardados", "Aceptar");
                Navigation.PushAsync(new Resumen(estudiante, nombre, pago, montoInicial));
            }
            else
            {
                DisplayAlert("Error", "Complete la información", "Aceptar");
            }
        }

        private void txtMonto_Unfocused(object sender, FocusEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMonto.Text))
            {
                if (!Validacion.ValidacionNumerica(txtMonto.Text))
                {
                    txtMonto.Text = "";
                    DisplayAlert("Error", "El monto no debe ser menor a $1 o superior a $3000", "Aceptar");
                }
            }
        }
    }
}