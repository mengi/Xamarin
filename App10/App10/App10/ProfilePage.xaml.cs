using Acr.UserDialogs;
using App10.ItemModel;
using App10.Model;
using App10.View;
using Plugin.Share;
using Plugin.Share.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App10
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        public string Url = "http://www.iqturkey.com/";
        List<CardDataAnnuoncModel> listAnnuoncModel;
        private bool _isRefreshing = false;
        private bool _isBusy = false;
        public ProfilePage()
        {
            InitializeComponent();
            this.Title = "Home";
            BindingContext = this;
            getLoadData();
        }

        private void onSelectedAnnounc(object sender, SelectedItemChangedEventArgs e)
        {
            ListView listAnnounc = (ListView)sender;

            if (e.SelectedItem != null)
            {
                var selectedAnnouncModel = (CardDataAnnuoncModel)e.SelectedItem;
                Navigation.PushAsync(new AnnouncDetailPage(selectedAnnouncModel, (int)App.AnnuncType.ANNUONCNORMAL));
            }

            listAnnounc.SelectedItem = null;
        }

        private async void onFilter()
        {
            var loginResult = await UserDialogs.Instance.LoginAsync("Login", "Please sign in");
            if (loginResult.Ok)
            {
                UserDialogs.Instance.Toast(String.Format("{0}:{1}", loginResult.Value.UserName, loginResult.Value.Password));
                await Navigation.PushAsync(new UserLoginPage());
            }
        }

        private async void onLogin()
        {
            if (!App.IsUserLoggedIn)
            {
                await Navigation.PushAsync(new UserLoginPage());
            }
            else
            {
               await Navigation.PushAsync(new UserMenuPage(App.userModel));
            }
        }
        
        /*
        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                OnPropertyChanged(nameof(IsBusy));
            }
        }
        */

        public bool IsRefreshing
        {
            get { return _isRefreshing; }
            set
            {
                _isRefreshing = value;
                OnPropertyChanged(nameof(IsRefreshing));
            }
        }

        public ICommand RefreshCommand
        {
            get
            {
                return new Command(async () =>
                {
                    _isRefreshing = true;
                    getDataAnnuonc();
                    IsRefreshing = false;
                });
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            getLoadData();
        }

        public async void getLoadData()
        {
            listAnnuoncModel = new List<CardDataAnnuoncModel>();
            listAnnuoncModel.Add(new CardDataAnnuoncModel
            {
                HeadId = 1,
                HeadTitle = " 9 hrs ago   - The Indipendendent",
                HeadLines = "Game of THrones season 7",
                HeadLinesDesc = "The Independent is a British online newspaper. Small sample based on your scenario. " +
                "Please review my project and let us know",
                HeadView = 12315,
                ProfileImage = "katty.jpg"
            });

            listAnnuoncModel.Add(new CardDataAnnuoncModel
            {
                HeadId = 2,
                HeadTitle = " 15 hrs ago - Android Authority",
                HeadLinesDesc = "If you have read Jules Verne’s Around the World, small sample based on your scenario. " +
                "Please review my project and let us know",
                HeadLines = "Set it and forget it",
                HeadView = 1215,
                ProfileImage = "me_photo.jpg"
            });

            listAnnuoncModel.Add(new CardDataAnnuoncModel
            {
                HeadId = 3,
                HeadTitle = " 19 hrs ago - Android Authority",
                HeadLinesDesc = "Please review my project and let us know",
                HeadLines = "Set it and forget it",
                HeadView = 1015,
                ProfileImage = "doktor.jpg"
            });

            listAnnuoncModel.Add(new CardDataAnnuoncModel
            {
                HeadId = 4,
                HeadTitle = " 20 hrs ago - Android Authority",
                HeadLinesDesc = "If you have read Jules Verne’s on your scenario. Please review my project and let us know",
                HeadLines = "Set it and forget it",
                HeadView = 315,
                ProfileImage = "jeniffer.jpg"
            });

            listAnnuoncModel.Add(new CardDataAnnuoncModel
            {
                HeadId = 1,
                HeadTitle = " 9 hrs ago   - The Indipendendent",
                HeadLines = "Game of THrones season 7",
                HeadLinesDesc = "The Independent is a British online newspaper. Small sample based on your scenario. " +
                "Please review my project and let us know",
                HeadView = 12315,
                ProfileImage = "katty.jpg"
            });

            listAnnuoncModel.Add(new CardDataAnnuoncModel
            {
                HeadId = 3,
                HeadTitle = " 19 hrs ago - Android Authority",
                HeadLinesDesc = "Please review my project and let us know",
                HeadLines = "Set it and forget it",
                HeadView = 1015,
                ProfileImage = "doktor.jpg"
            });

            listAnnuoncModel.Add(new CardDataAnnuoncModel
            {
                HeadId = 4,
                HeadTitle = " 20 hrs ago - Android Authority",
                HeadLinesDesc = "If you have read Jules Verne’s on your scenario. Please review my project and let us know",
                HeadLines = "Set it and forget it",
                HeadView = 315,
                ProfileImage = "jeniffer.jpg"
            });
            
            listViewAnnounc.ItemsSource = listAnnuoncModel;
        }

        public void getDataAnnuonc()
        {
            listAnnuoncModel = new List<CardDataAnnuoncModel>();
            listAnnuoncModel.Add(new CardDataAnnuoncModel
            {
                HeadId = 1,
                HeadTitle = " 9 hrs ago   - The Indipendendent",
                HeadLines = "Game of THrones season 7",
                HeadLinesDesc = "The Independent is a British online newspaper. Small sample based on your scenario. " +
                "Please review my project and let us know",
                HeadView = 12315,
                ProfileImage = "katty.jpg"
            });

            listAnnuoncModel.Add(new CardDataAnnuoncModel
            {
                HeadId = 2,
                HeadTitle = " 15 hrs ago - Android Authority",
                HeadLinesDesc = "If you have read Jules Verne’s Around the World, small sample based on your scenario. " +
                "Please review my project and let us know",
                HeadLines = "Set it and forget it",
                HeadView = 1215,
                ProfileImage = "me_photo.jpg"
            });

            listAnnuoncModel.Add(new CardDataAnnuoncModel
            {
                HeadId = 3,
                HeadTitle = " 19 hrs ago - Android Authority",
                HeadLinesDesc = "Please review my project and let us know",
                HeadLines = "Set it and forget it",
                HeadView = 1015,
                ProfileImage = "doktor.jpg"
            });

            listAnnuoncModel.Add(new CardDataAnnuoncModel
            {
                HeadId = 4,
                HeadTitle = " 20 hrs ago - Android Authority",
                HeadLinesDesc = "If you have read Jules Verne’s on your scenario. Please review my project and let us know",
                HeadLines = "Set it and forget it",
                HeadView = 315,
                ProfileImage = "jeniffer.jpg"
            });

            listAnnuoncModel.Add(new CardDataAnnuoncModel
            {
                HeadId = 1,
                HeadTitle = " 9 hrs ago   - The Indipendendent",
                HeadLines = "Game of THrones season 7",
                HeadLinesDesc = "The Independent is a British online newspaper. Small sample based on your scenario. " +
                     "Please review my project and let us know",
                HeadView = 12315,
                ProfileImage = "katty.jpg"
            });

            listViewAnnounc.ItemsSource = listAnnuoncModel;
        }

        public void annuoncSearchButton(object sender, EventArgs e)
        {
            /*
            var keyword = annuoncSearch.Text;

            var suggestions = listAnnuoncModel.Where(annuonc => annuonc.HeadLinesDesc.ToLower().Contains(keyword.ToLower()));

            listViewAnnounc.ItemsSource = suggestions;
            */
        }

        public void onAnnuoncTextChanged(object sender, TextChangedEventArgs e)
        {
            var keyword = annuoncSearch.Text;
            var newAnnuoncList = listAnnuoncModel.Where(annuonc => annuonc.HeadLinesDesc.ToLower().Contains(keyword.ToLower()));
            listViewAnnounc.ItemsSource = newAnnuoncList;
        }
    }
}