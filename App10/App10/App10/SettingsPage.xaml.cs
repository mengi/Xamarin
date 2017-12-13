using App10.Model;
using App10.View;
using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App10
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
            this.Title = "About";
            getInit();

            ButtonSettingCall.Clicked += (sender, e) =>
            {
                var phoneCallTask = CrossMessaging.Current.PhoneDialer;
                if (phoneCallTask.CanMakePhoneCall)
                    phoneCallTask.MakePhoneCall("050780702965");
            };
        }

        private void getInit()
        {
            lbldoctorName.Text = "Dr. Edward Salamon";

            lblCv.Text = "In 1987 she graduated from TED Ankara College. He graduated from Hacettepe University Faculty of Medicine in 1993. He completed his specialty in dermatology in 1997. Until September 2009, he worked in Ataturk Research and Training Hospital of Ministry of Health. Since 2010, " +
                "he has been serving his patients in dermatology and cosmetology fields.She has been working in cosmetology since 1998.There are certificates on mesotherapy, cryotherapy, laser, dermatocerapy, Botox, filling materials and chemical peeling application.";

            lblPhoneNumber.Text = "507-807-0296";
        }

        private void onRequest()
        {
            UserModel userModel = new UserModel();
            RequestUserModel requestModel = new RequestUserModel();
            Navigation.PushAsync(new RequestPage(userModel = null, requestModel = null));
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