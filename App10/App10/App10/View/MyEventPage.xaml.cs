using App10.Model;
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
    public partial class MyEventPage : ContentPage
    {

        public MyEventPage(UserModel userModel)
        {
            InitializeComponent();
            this.Title = "My Event";
            BindingContext = this;
            getDataEvent();
        }

        private void onMyEvent()
        {
            RequestUserModel requestModel = new RequestUserModel();
            Navigation.PushAsync(new RequestPage(App.userModel, requestModel = null));
        }

        private async void onSelectedEvent(object sender, SelectedItemChangedEventArgs e)
        {
            ListView listViewEvent = (ListView)sender;

            if (e.SelectedItem != null)
            {
                var requestUserModel = (RequestUserModel)e.SelectedItem;
                
                if (requestUserModel.reState.Equals(1))
                {
                    bool isOk = await DisplayAlert("Operation", "Please Select an Action", "Update", "Delete");

                    if (isOk)
                    {
                        await Navigation.PushAsync(new RequestPage(App.userModel, requestUserModel));
                    }
                    else
                    {
                        Helpers.XFToast.ShortMessage("Notified My Event Delete");
                       
                    }
                }

                if (requestUserModel.reState.Equals(0))
                {
                    bool isOk = await DisplayAlert("Operation", "Please Select an Action", "Update", "Delete");

                    if (isOk)
                    {
                        await Navigation.PushAsync(new RequestPage(App.userModel, requestUserModel));
                    }
                    else
                    {
                        Helpers.XFToast.ShortMessage("Waiting My Event Delete");
                    }
                }
            }

            listViewEvent.SelectedItem = null;
        }

        public void getDataEvent()
        {
            List<RequestUserModel> listEvents = new List<RequestUserModel>();

            // Bekliyor
            listEvents.Add(new RequestUserModel
            {
                reUserName = "Alexa Alvaro",
                reUserDay = new DateTime(2017, 12, 18),
                reUserPhone = "556-886-81-94",
                reUserService = "0",
                reUserMessage = "How are you ?",
                reState = 0,

            });

            // Geçmiş
            listEvents.Add(new RequestUserModel
            {
                reUserName = "Alexa Alvaro",
                reUserDay = new DateTime(2017, 11, 18),
                reUserPhone = "556-886-81-94",
                reUserService = "1",
                reUserMessage = "How are you ?",
                reState = 2
            });

            // Onaylanmış
            listEvents.Add(new RequestUserModel
            {
                reUserName = "Alexa Alvaro",
                reUserDay = new DateTime(2017, 12, 09),
                reUserPhone = "556-886-81-94",
                reUserService = "2",
                reUserMessage = "How are you ?",
                reState = 1
            });

            myEventListView.BindingContext = listEvents;
        }
    }
}