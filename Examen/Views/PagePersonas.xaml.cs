using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagePersonas : ContentPage
    {
        public PagePersonas()
        {
            InitializeComponent();
        }

        private async void btnproceso_Clicked(object sender, EventArgs e)
        {
            var person = new Models.Personas
            {
                Nombre = Nombre.Text,
                Telefono = Telefono.Text,
                Edad = Edad.Text,
                Pais = Pais.Text,
                Nota = Nota.Text,
            };
            
            
            if (await App.DataBase.AddPersona(person) > 0)
            {
                await DisplayAlert("Aviso", "Persona ingresada con esito", "OK");
            }
            else
            {
                await DisplayAlert("Aviso", "No se pudo ingresar ", "Ok");
            }
        }
    }
}