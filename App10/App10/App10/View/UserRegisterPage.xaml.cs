using App10.Utils;
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
    public partial class UserRegisterPage : ContentPage
    {
        public UserRegisterPage()
        {
            InitializeComponent();

            registerButtonSave.Clicked += (sender, args) =>
            {
                getValidation();
            };

        }

        private void getValidation()
        {

            if (string.IsNullOrEmpty(registerUserName.Text) &&
                string.IsNullOrEmpty(registerUserPassword.Text))
            {

                Helpers.XFToast.ShortMessage("Register failed");

                //DisplayAlert("Alert", "Register failed", "Cancel");
                return;
            }
            else
            {
                EmailValid emailValid = new EmailValid();
                emailValid.emailAddress = registerUserEmail.Text.ToString();
                if (emailValid.IsValidEmail())
                {
                    if (registerUserPassword.Text.Length > 7)
                    {
                        Helpers.XFToast.ShortMessage("Register");
                        //DisplayAlert("Success", "Register", "Cancel");
                        Navigation.RemovePage(this);
                    }
                    else
                    {
                        Helpers.XFToast.ShortMessage("Register Password little 8");
                        //DisplayAlert("Alert", "Register Password little 8", "Cancel");
                        return;
                    }
                }
                else
                {
                    Helpers.XFToast.ShortMessage("Email Error");
                    //DisplayAlert("Alert", "Email Error", "Cancel");
                    return;
                }

            }

        }
    }
}