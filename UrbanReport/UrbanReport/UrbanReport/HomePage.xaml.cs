using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrbanReport;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UrbanReport
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : TabbedPage
	{
		public HomePage ()
		{
			InitializeComponent ();
		}

        private void Add_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewReportPage());
        }
    }
}