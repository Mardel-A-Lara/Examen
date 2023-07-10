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
    public partial class PageListPersonas : ContentPage
    {
        public PageListPersonas()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            Listapersonas.ItemsSource = await App.DataBase.GetAllPersonas();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var page = new Views.PagePersonas();
            Navigation.PushAsync(page);
        }
    }
}