using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Examen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSalvar_Clicked(object sender, EventArgs e)
        {
            var Personas = new Models.Personas
            {
                id = 1,
                Nombre = "Mardel",
                Telefono = "9699-2323",
                Edad = "23",
                Pais = "Honduras",
                Nota = "hola hola hola",
            };
        }
    }
}
