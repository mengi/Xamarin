using App10.Model;
using App10.Utils;
using Plugin.Media;
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
	public partial class UserInfoPage : ContentPage
	{
        UserModel users;
		public UserInfoPage (UserModel userModel)
		{
			InitializeComponent ();
            this.Title = App.userModel.userName;
            users = userModel;
            this.BindingContext = userModel;

           
            ButtonSave.Clicked += (sender, args) => { getValidation(); };
        }

        private void getValidation()
        {
            if (!string.IsNullOrEmpty(userEmail.Text.ToString()) && !string.IsNullOrEmpty(userName.Text.ToString()))
            {
                EmailValid emailValid = new EmailValid();
                emailValid.emailAddress = userEmail.Text.ToString();

                if (emailValid.IsValidEmail())
                {
                    if (userPhone.Text.Length != 11)
                    {
                        Helpers.XFToast.ShortMessage("Telephone Error");
                        return;
                    }
                    else
                    {
                        try
                        {
                            UserModel userModels = new UserModel();

                            userModels.userId = users.userId;
                            userModels.userPassword = users.userPassword;
                            userModels.userBirthday = userBirthday.Date;
                            userModels.userBloodGroup = userBloodType.SelectedIndex.ToString();
                            userModels.userEmail = userEmail.Text.ToString();
                            userModels.userGender = userGender.SelectedIndex.ToString();
                            userModels.userImageUrl = userImage.ToString();
                            userModels.userName = userName.Text.ToString();
                            userModels.userNationality = userNationalityType.SelectedIndex.ToString();
                            userModels.userPhone = userPhone.Text.ToString();

                            Helpers.XFToast.ShortMessage("Save Success");
                            
                        }
                        catch (Exception ex) { ex.Message.ToString(); }
                    }
                }
                else
                {
                    Helpers.XFToast.ShortMessage("Email Error");
                    return;
                }
            }
            else
            {
                Helpers.XFToast.ShortMessage("Name and Email inValid");
                return;
            }
        }

        private async void onPhoto()
        {
            try
            {
                if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                {
                    Helpers.XFToast.ShortMessage("Camera Error");
                    return;
                }

                var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
                {
                    Directory = "",
                    Name = App.userModel.userName + ".jpg" 
                });

                if (file != null)
                {
                    userImage.Source = ImageSource.FromStream(() =>
                    {
                        var stream = file.GetStream();
                        file.Dispose();
                        return stream;
                    });
                }
                else
                {
                    Helpers.XFToast.ShortMessage("File Image Save Error");
                    return;
                }
            }
            catch (Exception ex) { ex.Message.ToString(); } 
        }
    }
}