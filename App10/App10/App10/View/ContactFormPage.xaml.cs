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
    public partial class ContactFormPage : ContentPage
    {
        public ContactFormPage()
        {
            InitializeComponent();
            this.Title = "Contact Form Page";

            contactButton.Clicked += (sender, args) =>
            {
                getValidation();
            };
        }

        private void getValidation()
        {

            if (string.IsNullOrEmpty(contactUserName.Text) &&
                string.IsNullOrEmpty(contactUserTopic.Text) &&
                string.IsNullOrEmpty(contactUserMessagge.Text))
            {
                Helpers.XFToast.ShortMessage("Contact failed");
                //DisplayAlert("Alert", "Contact failed", "Cancel");
                return;
            }
            else
            {
                EmailValid emailValid = new EmailValid();
                emailValid.emailAddress = contactUserEmail.Text.ToString();
                if (emailValid.IsValidEmail())
                {
                    Helpers.XFToast.ShortMessage("Contact");
                    //DisplayAlert("Success", "Request", "Cancel");
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