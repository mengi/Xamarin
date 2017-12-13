using App10.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App10.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FavoriteAnnuoncListPage : ContentPage
    {
        private bool _isRefreshing = false;
        public FavoriteAnnuoncListPage()
        {
            InitializeComponent();
            this.Title = "My Favorite";
            BindingContext = this;
            FavoriteAnnuoncListView.ItemsSource = App.favoriteAnnuoncList;
        }

        private void onSelectedFavoriteAnnuonc(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                ListView listAnnuonc = (ListView)sender;
                if (e.SelectedItem != null)
                {
                    var selectedAnnouncModel = (CardDataAnnuoncModel)e.SelectedItem;
                    Navigation.PushAsync(new AnnouncDetailPage(selectedAnnouncModel, (int)App.AnnuncType.ANNUONCFAVORITE));
                }

                listAnnuonc.SelectedItem = null;
            }
            catch (Exception ex) { ex.Message.ToString(); }
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            FavoriteAnnuoncListView.ItemsSource = null;
            FavoriteAnnuoncListView.ItemsSource = App.favoriteAnnuoncList;
        }

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
                    getDataFavorite();
                    IsRefreshing = false;
                });
            }
        }

        public void getDataFavorite()
        {
            FavoriteAnnuoncListView.ItemsSource = App.favoriteAnnuoncList;
        }
    }
}