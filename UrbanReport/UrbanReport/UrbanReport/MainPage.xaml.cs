using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrbanReport.Model;
using Xamarin.Forms;

namespace UrbanReport
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            if(User.Text=="420" && Pass.Text=="420")
            {
                await Navigation.PushAsync(new HomePage());
            }
            if (string.IsNullOrEmpty(User.Text) || string.IsNullOrEmpty(Pass.Text))
            {

            }
            else
            {
                //var user = (await App.MobileService.GetTable<User>().Where(
                //    x => x.Email == User.Text).ToListAsync()).FirstOrDefault();
                //if (user != null)
                //{
                //    App.user = user;
                //    if (user.Password == Pass.Text)
                //    {
                //        await Navigation.PushAsync(new HomePage());
                //    }
                //    else
                //    {
                //        await DisplayAlert("Error", "Clave o Correo Incorrectos", "Ok");
                //    }
                //}
                //else
                //{
                //    await DisplayAlert("Error", "Error Iniciando Sesión", "Ok");
                //}

            }
        }

        private void RegisterUserButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }
    }
}
