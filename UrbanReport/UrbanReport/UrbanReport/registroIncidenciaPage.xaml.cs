using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrbanReport.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml; 
using Xamarin.Forms.ImagePicker;
using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;

namespace UrbanReport
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registroIncidenciaPage : ContentPage
    {
        private IImagePickerService _imagePickerService;
 
        private Position position;
        public registroIncidenciaPage()
        {
            _imagePickerService = DependencyService.Get<IImagePickerService>();
            InitializeComponent();

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            var locator = CrossGeolocator.Current;
             position = await locator.GetPositionAsync();
        }

        private  void EnviarIncidencia_Clicked(object sender, EventArgs e)
        {
          
            var i = new incidencia
            {
               latitude=position.Latitude,
               longitud=position.Longitude
            };
           
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var imageSource = await _imagePickerService.PickImageAsync();

            if (imageSource != null) // it will be null when user cancel
            {
                image.Source = imageSource;
            }

            //using (System.IO.Stream stream = await imagePickerService.ImageSourceUtility.ToJpegStreamAsync(imageSource))
            //{
            //    // ...
            //}
        }
    }
}