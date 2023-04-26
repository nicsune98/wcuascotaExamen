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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btIngreso_Clicked(object sender, EventArgs e)
        {
            string estudiante = txtUsuario.Text;
            if (txtUsuario.Text == "estudiante2023" && txtContraseña.Text == "uisrael2023")
            {
                Navigation.PushAsync(new Registro(estudiante));
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
            else
            {
                DisplayAlert("Error", "Usuario o Contraseña incorrectos", "Aceptar");
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
        }
    }
}