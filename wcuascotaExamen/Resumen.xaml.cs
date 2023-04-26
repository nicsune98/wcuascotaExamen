using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace wcuascotaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {
        public Resumen(string estudiante, string nombre, double pago, double monto)
        {
            InitializeComponent();
            lblEstudiante.Text =estudiante;
            lblNombre.Text = nombre;
            lblPago.Text = Convert.ToString(pago+monto);

        }
    }
}