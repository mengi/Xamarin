using App10.Model;
using App10.View;
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
    public partial class PracticePage : ContentPage
    {
        public PracticePage()
        {
            InitializeComponent();
            this.Title = "Practic";

            List<TopCategoryModel> listTopCategory = new List<TopCategoryModel>();

            listTopCategory.Add(new TopCategoryModel
            {
                topId = 1,
                topTitle = "CİLT GENÇLEŞTİRME",
                topImageUrl = "cilt.jpg"
            });

            listTopCategory.Add(new TopCategoryModel
            {
                topId = 2,
                topTitle = "LAZER UYGULAMALARI",
                topImageUrl = "lazer.jpg"
            });

            listTopCategory.Add(new TopCategoryModel
            {
                topId = 3,
                topTitle = "BÖLGESEL ZAYIFLAMA",
                topImageUrl = "bolgesel_zayiflama.jpg"
            });

            listTopCategory.Add(new TopCategoryModel
            {
                topId = 4,
                topTitle = "DİĞER UYGULAMALAR",
                topImageUrl = "diger.jpg"
            });

            listViewPractices.BindingContext = listTopCategory;
        }

        private void onSelectedPratice(object sender, SelectedItemChangedEventArgs e)
        {
            ListView listPractice = (ListView)sender;

            if (e.SelectedItem != null)
            {
                var selectedTop = (TopCategoryModel)e.SelectedItem;
                Navigation.PushAsync(new SubCategoryPage(selectedTop));
            }

            listPractice.SelectedItem = null;
        }

        private void onFilter()
        {
            Helpers.XFToast.ShortMessage("Filter");
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