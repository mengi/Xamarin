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
    public partial class UserMenuPage : ContentPage
    {
        public UserModel userModels;
        public UserMenuPage(UserModel userModel)
        {
            InitializeComponent();
            this.Title = "Hesap";

            this.circleUserImage.Source = userModel.userImageUrl;
            this.lblUserName.Text = App.userModel.userName;
            userModels = userModel;

            List<UserMenuModel> userMenuList = new List<UserMenuModel>();

            userMenuList.Add(new UserMenuModel { MenuId = 1, IconPath = "ic_perm_identity_black_24dp.png", Description = "User Information" });
            userMenuList.Add(new UserMenuModel { MenuId = 2, IconPath = "ic_thumb_up_black_24dp.png", Description = "My Favorites" });
            userMenuList.Add(new UserMenuModel { MenuId = 3, IconPath = "ic_question_answer_black_24dp.png", Description = "Chat Doctor" });
            userMenuList.Add(new UserMenuModel { MenuId = 4, IconPath = "ic_event_note_black_24dp.png", Description = "My Event" });
            userMenuList.Add(new UserMenuModel { MenuId = 5, IconPath = "ic_local_hospital_black_24dp.png", Description = "My Treatment" });
            userMenuList.Add(new UserMenuModel { MenuId = 6, IconPath = "ic_content_paste_black_24dp.png", Description = "My Prescription" });
            userMenuList.Add(new UserMenuModel { MenuId = 7, IconPath = "ic_content_copy_black_24dp.png", Description = "My Transactions" });
            userMenuList.Add(new UserMenuModel { MenuId = 8, IconPath = "ic_exit_to_app_black_24dp.png", Description = "Logout" });

            UserMenuListView.BindingContext = userMenuList;
        }

        private void onSelectedUserMenu(object sender, SelectedItemChangedEventArgs e)
        {
            ListView listUserMenu = (ListView)sender;

            if (e.SelectedItem != null)
            {
                UserMenuModel userMenuModel = (UserMenuModel)e.SelectedItem;

                switch (userMenuModel.MenuId)
                {
                    case 1:
                        Navigation.PushAsync(new UserInfoPage(userModels));
                        break;
                    case 2:
                        if (App.favoriteAnnuoncList.Count > 0)
                        {
                            Navigation.PushAsync(new FavoriteAnnuoncListPage());
                        }
                        else
                        {
                            Helpers.XFToast.ShortMessage("Favorite Size 0");
                        }

                        break;
                    case 3:
                        Helpers.XFToast.ShortMessage(userMenuModel.Description);
                        break;
                    case 4:
                        Navigation.PushAsync(new MyEventPage(userModels));
                        //Helpers.XFToast.ShortMessage(userMenuModel.Description);
                        break;
                    case 5:
                        Navigation.PushAsync(new MyTreatmentPage(App.userModel));
                        //Helpers.XFToast.ShortMessage(userMenuModel.Description);
                        break;
                    case 6:
                        Helpers.XFToast.ShortMessage(userMenuModel.Description);
                        break;
                    case 7:
                        Helpers.XFToast.ShortMessage(userMenuModel.Description);
                        break;
                    case 8:
                        App.IsUserLoggedIn = false;
                        Navigation.RemovePage(this);
                        break;
                }
            }

            listUserMenu.SelectedItem = null;
        }
    }
}