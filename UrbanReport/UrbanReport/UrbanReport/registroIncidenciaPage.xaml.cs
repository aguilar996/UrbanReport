using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrbanReport.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml; 
using Xamarin.Forms.ImagePicker;

namespace UrbanReport
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registroIncidenciaPage : ContentPage
    {
        private IImagePickerService _imagePickerService;
        public registroIncidenciaPage()
        {
            _imagePickerService = DependencyService.Get<IImagePickerService>();
            InitializeComponent();
        }

        private void EnviarIncidencia_Clicked(object sender, EventArgs e)
        {
            var i = new incidencia
            {
              
            };
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var imageSource = await _imagePickerService.PickImageAsync();

            if (imageSource != null) // it will be null when user cancel
            {
                image.Source = imageSource;
            }
        }
    }
}