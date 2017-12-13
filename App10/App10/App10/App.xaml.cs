using App10.Interfaces;
using App10.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App10
{
    public partial class App : Application
    {

        public static bool IsUserLoggedIn { get; set; }
        public static UserModel userModel;
        public static List<CardDataAnnuoncModel> favoriteAnnuoncList;
        public enum AnnuncType { ANNUONCNORMAL = 1, ANNUONCFAVORITE = 2 };
        public enum RequestType { REQUESTACTIVE = 3, REQUESTPASSIVE = 4 };
        public static IList<KeyValuePair<int, string>> listSubImage;
        public static IList<KeyValuePair<int, string>> listSubName;
        public App()
        {
            InitializeComponent();
            favoriteAnnuoncList = new List<CardDataAnnuoncModel>();
            userModel = new UserModel { userId = 1, userName = "Edward Salamon",
                userEmail = "iqsmart@gmail.com", userPassword = "iq",
                userImageUrl = "https://avante.biz/wp-content/uploads/Cat-Hd-Wallpaper/Cat-Hd-Wallpaper-001.jpg",
                userNationality = "0",
                userPhone = "05068060195",
                userBirthday = new DateTime(1993, 4, 3), 
                userGender = "0",
                userBloodGroup = "2"
            };

            listSubImage = new List<KeyValuePair<int, string>>();
            listSubImage.Add(new KeyValuePair<int, string>(0, "dolgu.jpg"));
            listSubImage.Add(new KeyValuePair<int, string>(1, "goz_alti_isik_dolgusu.jpg"));
            listSubImage.Add(new KeyValuePair<int, string>(2, "leke.jpg"));
            listSubImage.Add(new KeyValuePair<int, string>(3, "goz_alti_isik_dolgusu.jpg"));
            listSubImage.Add(new KeyValuePair<int, string>(4, "bolgesel.jpg"));

            listSubName = new List<KeyValuePair<int, string>>();
            listSubName.Add(new KeyValuePair<int, string>(0, "Yüz ve Dudak Dolgusu"));
            listSubName.Add(new KeyValuePair<int, string>(1, "Göz Altı Işık Dolgusu"));
            listSubName.Add(new KeyValuePair<int, string>(2, "Fraksiyonel CO2 Lazer"));
            listSubName.Add(new KeyValuePair<int, string>(3, "Q-Switched Nd:YAG Lazer"));
            listSubName.Add(new KeyValuePair<int, string>(4, "Bölgesel Zayıflama"));

            //MainPage = new NavigationPage(new MainPage());
            MainPage = new SplashPage();

            //MainPage = new YoutubeViewPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
