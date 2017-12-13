using App10.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Plugin.Messaging;
using Plugin.ExternalMaps;
using Xamarin.Forms.Xaml;

namespace App10
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactMain : ContentPage
    {
        public ContactMain()
        {
            InitializeComponent();
            this.Title = "Contact";
            getInit();

            ButtonContactCall.Clicked += (sender, e) => {
                var phoneCallTask = CrossMessaging.Current.PhoneDialer;
                if (phoneCallTask.CanMakePhoneCall)
                    phoneCallTask.MakePhoneCall("+903122359198");
            };

            ButtonContactNavigation.Clicked += (sender, e) => {
                CrossExternalMaps.Current.NavigateTo("IQ Smart", 39.8913413, 32.7013437);
            };
        }

        private void getInit()
        {
            lblfirmName.Text = "IQ Smart";
            lblPhoneNumber.Text = "+90 (312) 235 91 98";
            lblAddress.Text = "Ümit Mah. 2513. Sk. Çamlıcaevleri Sitesi A1 Blok 9/16 Ümitköy Çankaya / ANKARA";
            lblPhone.Text = "+90 (312) 235 91 98";
            lblEmailAdress.Text = "bilgi@iqturkey.com";
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
            var position = new Position(39.8913413, 32.7013437);
            MyMap.MapType = MapType.Street;

            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = lblfirmName.Text,
                Address = lblAddress.Text
            };

            MyMap.Pins.Add(pin);
            MyMap.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                    position, Distance.FromMiles(.2)));
        }

       

        private void onContact()
        {
            Navigation.PushAsync(new ContactFormPage());
        }

        private void onLogin()
        {
            if (!App.IsUserLoggedIn)
            {
                Navigation.PushAsync(new UserLoginPage());
            }
            else
            {
                Navigation.PushAsync(new UserMenuPage(App.userModel));
            }
        }
    }
}