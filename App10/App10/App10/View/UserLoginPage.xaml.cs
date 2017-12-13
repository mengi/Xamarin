using App10.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App10.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserLoginPage : ContentPage
    {
        public UserLoginPage()
        {
            InitializeComponent();
            this.Title = "User Login";
            this.firmIcon.Source = "doktor.jpg";
            this.lblfirmName.Text = "IQ Smart";

            loginButton.Clicked += (sender, args) =>
            {
                getValidation();
            };

            loginRegisterButton.Clicked += (sender, args) => { Navigation.PushAsync(new UserRegisterPage()); };

            loginForgotPassword.Clicked += (sender, args) => { Helpers.XFToast.ShortMessage("Forgot My Password"); };

        }

        private void getValidation()
        {
            if (string.IsNullOrEmpty(loginUserEmail.Text) && string.IsNullOrEmpty(loginUserPassword.Text))
            {
                Helpers.XFToast.ShortMessage("login failed");
                //DisplayAlert("Alert", "login failed", "Cancel");
                return;
            }
            else
            {
                EmailValid emailValid = new EmailValid();
                emailValid.emailAddress = loginUserEmail.Text.ToString();
                if (emailValid.IsValidEmail())
                {
                    //Helpers.XFToast.ShortMessage("login");


                    if (App.userModel.userEmail.Equals(loginUserEmail.Text) && (App.userModel.userPassword.Equals(loginUserPassword.Text)))
                    {
                        App.IsUserLoggedIn = true;
                        Navigation.RemovePage(this);
                        Navigation.PushAsync(new UserMenuPage(App.userModel));
                    }
                    else
                    {
                        Helpers.XFToast.ShortMessage("Email or Password Error");
                    } 

                    //DisplayAlert("Success", "Login", "Cancel");
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