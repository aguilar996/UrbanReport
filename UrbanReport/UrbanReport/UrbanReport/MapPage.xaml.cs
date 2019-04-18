using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;
using Xamarin.Forms.Maps;
using UrbanReport.Models;

namespace UrbanReport
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MapPage : ContentPage
	{
        private bool hasLocationPermission;
		public MapPage ()
		{
                InitializeComponent();
                GetPermissions();
        }

        private async void GetPermissions()
        {
            try
            {
               
            var PermStatus = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.LocationWhenInUse);
            if(PermStatus!= PermissionStatus.Granted)
            {
                    if (await CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Permission.LocationWhenInUse))
                    {
                        await DisplayAlert("Necesitamos su ubicación", "Su ubicación esnecesaria para reportar", "OK");
                    }
                    var results = await CrossPermissions.Current.RequestPermissionsAsync(Permission.LocationWhenInUse);
                    if(results.ContainsKey(Permission.LocationWhenInUse))
                    { 
                    PermStatus = results[Permission.LocationWhenInUse];
                    }
            }
                if (PermStatus == PermissionStatus.Granted)
                {
                    LocationMap.IsShowingUser = true;
                    hasLocationPermission = true;
                    GetLocation();
                }
                    else
                    {
                        await DisplayAlert("Problema de Localización", "No pudimos determinar su ubicación", "OK");
                    }
            }
            catch(Exception e)
            {
                await DisplayAlert("Error", e.Message, "OK");
            }
        }

      
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if(hasLocationPermission)
            {
                var locator = CrossGeolocator.Current;
                locator.PositionChanged += Locator_PositionChanged;
                await locator.StartListeningAsync(TimeSpan.Zero, 100);
            }
            GetLocation();
            //Azure db
            //var incidencias = await App.MobileService.GetTable<incidencia>()
            //    .Where(p => p.Id == App.user.Id).ToListAsync();
            //DisplayInMap(incidencias);
        }

        private void DisplayInMap(List<incidencia> incidencias)
        {
            foreach(var incidencia in incidencias)
            {
                try
                {

                var position = new Xamarin.Forms.Maps.Position(incidencia.latitude,incidencia.longitud);
                var pin = new Pin()
                {
                    Type = PinType.SavedPin,
                    Position = position,
                    Label = "",
                    Address = ""
                };
                LocationMap.Pins.Add(pin);
                }
                catch(NullReferenceException Nre)
                {

                }
                catch(Exception e)
                {

                }

            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            CrossGeolocator.Current.StopListeningAsync();
            CrossGeolocator.Current.PositionChanged -= Locator_PositionChanged;
        }
         
        private async void GetLocation()
        {
            if(hasLocationPermission)
            {
            var locator = CrossGeolocator.Current;
            var position = await locator.GetPositionAsync();
                MoveMap(position);
            }
                
        } 
        void Locator_PositionChanged(Object sender, PositionEventArgs e)
        {
            MoveMap(e.Position);
        } 
        private void MoveMap(Plugin.Geolocator.Abstractions.Position position)
        {
            var center = new Xamarin.Forms.Maps.Position(position.Latitude, position.Longitude);
            var span = new Xamarin.Forms.Maps.MapSpan(center, 1, 1);
            LocationMap.MoveToRegion(span);
        }
    }


}