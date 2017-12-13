using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App10.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        public ContactPage()
        {
            InitializeComponent();
            this.Title = "Contact Page";
            getInit();
        }

        private void getInit()
        {
            lblfirmName.Text = "Beauty and Laser";
            lblPhoneNumber.Text = "507-807-02-96";
            lblAddress.Text = "Çekirge Sağlık Plaza Hüdavendigar Mahallesi Dikkaldırım Caddesi No:23 Osmangazi/BURSA";
            lblPhone.Text = "507-807-02-96";
            lblEmailAdress.Text = "info@edwardsalamon.com";
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
            /*
            var position = new Position(viewModel.Store.Latitude, viewModel.Store.Longitude); // Latitude, Longitude
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = position,
                Label = viewModel.Store.Name,
                Address = viewModel.Store.StreetAddress
            };
            MyMap.Pins.Add(pin);

            MyMap.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                    position, Distance.FromMiles(.2)));
            */
        }
    }
}