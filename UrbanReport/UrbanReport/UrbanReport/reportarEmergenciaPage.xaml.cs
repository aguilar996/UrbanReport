using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UrbanReport
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class reportarEmergenciaPage : ContentPage
    {
        public reportarEmergenciaPage()
        {
            InitializeComponent();
        }

        private void PoliciaButton_Clicked(object sender, EventArgs e)
        {
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall)
                phoneDialer.MakePhoneCall("+593983779996");
        }

        private void BomberosButton_Clicked(object sender, EventArgs e)
        {
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall)
                phoneDialer.MakePhoneCall("+593983779996");
        }

        private void CRButton_Clicked(object sender, EventArgs e)
        {
            var phoneDialer = CrossMessaging.Current.PhoneDialer;
            if (phoneDialer.CanMakePhoneCall)
                phoneDialer.MakePhoneCall("+593983779996");
        }
    }
}