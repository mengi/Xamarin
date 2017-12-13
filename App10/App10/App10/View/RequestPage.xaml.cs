using App10.Model;
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
    public partial class RequestPage : ContentPage
    {

        public RequestPage(UserModel userModels, RequestUserModel requestModel)
        {
            InitializeComponent();
            this.Title = "Request Form";

            if (userModels != null)
            {
                requestUserName.Text = userModels.userName;
                requestUserEmail.Text = userModels.userEmail;
                requestUserPhone.Text = userModels.userPhone;

                if (requestModel != null)
                {
                    requestUserMessage.Text = requestModel.reUserMessage;
                    requestUserService.SelectedIndex = Int32.Parse(requestModel.reUserService);
                    requestUserDay.Date = requestModel.reUserDay;

                    buttonRequest.Text = "Update";
                }
            }

            buttonRequest.Clicked += (sender, args) =>
            {
                if (userModels != null)
                {
                    if (requestModel != null)
                    {
                        getValidationTwoActive(userModels, requestModel);
                    }
                    else
                    {
                        getValidationActive(userModels);
                    }
                }
                else
                {
                    getValidationPassive();
                }
            };
        }

        private void getValidationTwoActive(UserModel user, RequestUserModel request)
        {
            try
            {

                if (string.IsNullOrEmpty(requestUserService.SelectedIndex.ToString()) ||
                    string.IsNullOrEmpty(requestUserDay.ToString()))
                {
                    Helpers.XFToast.ShortMessage("request user update failed");
                    //DisplayAlert("Alert", "request failed", "Cancel");
                    return;
                }
                else
                {
                    EmailValid emailValid = new EmailValid();
                    emailValid.emailAddress = requestUserEmail.Text.ToString();

                    if (emailValid.IsValidEmail())
                    {
                        if (requestUserPhone.Text.Length != 11)
                        {
                            Helpers.XFToast.ShortMessage("User Request Update Telephone Error");
                            //DisplayAlert("Alert", "Telephone Error", "Cancel");
                            return;
                        }
                        else
                        {
                            if (0 > DateTime.Compare(DateTime.Now, requestUserDay.Date) || DateTime.Compare(DateTime.Now, requestUserDay.Date) == 0)
                            {
                                request.reUserName = requestUserName.Text;
                                request.reUserPhone = requestUserPhone.Text;
                                request.reUserMessage = requestUserMessage.Text;
                                request.reUserService = requestUserService.SelectedIndex.ToString();
                                request.reUserDay = requestUserDay.Date;

                                Helpers.XFToast.ShortMessage("User Request Uodate");
                            }
                            else
                            {
                                Helpers.XFToast.ShortMessage("User Update Date Time Error");
                            }
                            //DisplayAlert("Success", "Request", "Cancel");
                        }
                    }
                    else
                    {
                        Helpers.XFToast.ShortMessage("User Update Email Error ");
                        //DisplayAlert("Alert", "Email Error", "Cancel");
                        return;
                    }
                }
            }
            catch (Exception e) { Helpers.XFToast.ShortMessage(e.Message.ToString()); }
        }

        private void getValidationActive(UserModel user)
        {
            try
            {

                if (string.IsNullOrEmpty(requestUserService.SelectedIndex.ToString()) ||
                    string.IsNullOrEmpty(requestUserDay.ToString()))
                {
                    Helpers.XFToast.ShortMessage("request user failed");
                    //DisplayAlert("Alert", "request failed", "Cancel");
                    return;
                }
                else
                {
                    EmailValid emailValid = new EmailValid();
                    emailValid.emailAddress = requestUserEmail.Text.ToString();

                    if (emailValid.IsValidEmail())
                    {
                        if (requestUserPhone.Text.Length != 11)
                        {
                            Helpers.XFToast.ShortMessage("User Telephone Error");
                            //DisplayAlert("Alert", "Telephone Error", "Cancel");
                            return;
                        }
                        else
                        {
                            if (0 > DateTime.Compare(DateTime.Now, requestUserDay.Date) || DateTime.Compare(DateTime.Now, requestUserDay.Date) == 0)
                            {
                                RequestUserModel requestUserModel = new RequestUserModel();
                                requestUserModel.reUserName = requestUserName.Text;
                                requestUserModel.reUserPhone = requestUserPhone.Text;
                                requestUserModel.reUserMessage = requestUserMessage.Text;
                                requestUserModel.reUserService = requestUserService.SelectedIndex.ToString();
                                requestUserModel.reUserDay = requestUserDay.Date;
                                requestUserModel.reState = 0;

                                Helpers.XFToast.ShortMessage("User Request");
                            }
                            else
                            {
                                Helpers.XFToast.ShortMessage("User Date Time Error");
                            }
                            //DisplayAlert("Success", "Request", "Cancel");
                        }
                    }
                    else
                    {
                        Helpers.XFToast.ShortMessage("User Email Error ");
                        //DisplayAlert("Alert", "Email Error", "Cancel");
                        return;
                    }
                }
            }
            catch (Exception e) { Helpers.XFToast.ShortMessage(e.Message.ToString()); }
        }

        private void getValidationPassive()
        {
            try
            {

                if (string.IsNullOrEmpty(requestUserName.Text) ||
                    string.IsNullOrEmpty(requestUserPhone.Text) ||
                    string.IsNullOrEmpty(requestUserMessage.Text) ||
                    string.IsNullOrEmpty(requestUserEmail.Text) ||
                    string.IsNullOrEmpty(requestUserService.SelectedIndex.ToString()) ||
                    string.IsNullOrEmpty(requestUserDay.ToString()))
                {
                    Helpers.XFToast.ShortMessage("request failed");
                    //DisplayAlert("Alert", "request failed", "Cancel");
                    return;
                }

                else
                {
                    EmailValid emailValid = new EmailValid();
                    emailValid.emailAddress = requestUserEmail.Text.ToString();

                    if (emailValid.IsValidEmail())
                    {
                        if (requestUserPhone.Text.Length != 11)
                        {
                            Helpers.XFToast.ShortMessage("Telephone Error");
                            //DisplayAlert("Alert", "Telephone Error", "Cancel");
                            return;
                        }
                        else
                        {
                            if (0 < DateTime.Compare(DateTime.Now, requestUserDay.Date) || DateTime.Compare(DateTime.Now, requestUserDay.Date) == 0)
                            {
                                RequestUserModel requestUserModel = new RequestUserModel();
                                requestUserModel.reUserName = requestUserName.Text;
                                requestUserModel.reUserPhone = requestUserPhone.Text;
                                requestUserModel.reUserMessage = requestUserMessage.Text;
                                requestUserModel.reUserService = requestUserService.SelectedIndex.ToString();
                                requestUserModel.reUserDay = requestUserDay.Date;
                                requestUserModel.reState = 0;

                                Helpers.XFToast.ShortMessage("Request");
                            }
                            else
                            {
                                Helpers.XFToast.ShortMessage("Date Time Error");
                            }
                            //DisplayAlert("Success", "Request", "Cancel");
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
            catch (Exception e) { Helpers.XFToast.ShortMessage(e.Message.ToString()); }
        }
    }
}