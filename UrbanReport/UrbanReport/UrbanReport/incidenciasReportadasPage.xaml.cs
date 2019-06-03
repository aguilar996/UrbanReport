using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using UrbanReport.Models;
namespace UrbanReport
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class incidenciasReportadasPage : ContentPage
    {
        public incidenciasReportadasPage()
        {
            InitializeComponent();
            var lista = new List<incidencia>();
            var incidencia1 = new incidencia
            {
                Fecha = new DateTime(19, 02, 27),
                Categoria= "Robo",
                Description= "Mano Armada tienda comercial"
            };

            var incidencia2 = new incidencia
            {
                Fecha = new DateTime(19, 02, 27),
                Categoria = "Disturbio Doméstico",
                Description = "Gritos en casa vencindario norte"
            };

            var incidencia3 = new incidencia
            {
                Fecha = new DateTime(19, 02, 27),
                Categoria = "Abandono familiar",
                Description = "Niño perdido en la zona mocoli"
            };

            var incidencia4 = new incidencia
            {
                Fecha = new DateTime(19, 02, 27),
                Categoria = "Robo",
                Description = "Robo vehicular centro de la ciudad"
            };
            lista.Add(incidencia1);
            lista.Add(incidencia2);
            lista.Add(incidencia3);
            lista.Add(incidencia4);

            PostListView.ItemsSource = lista;
        }
    }
}