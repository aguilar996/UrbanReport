using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace UrbanReport.Models
{
    class incidencia
    {
        public string Id { get; set; }
        public string Description { get; set; }

        public string Categoria { get; set; }

        public DateTime Fecha { get; set; }
        public double latitude {get;set;}
        public double longitud {get;set; }
       

    }
}
