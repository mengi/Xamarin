using App10.Model;
using App10.View;
using Plugin.Share;
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
    public partial class MoviesPage : ContentPage
    {
        public string YouTubeUrl = "https://www.youtube.com/watch?v=";
        private bool _isRefreshing = false;
        private List<MoviesModel> listMovieModels;
        public MoviesPage()
        {
            InitializeComponent();
            this.Title = "Movies";
            BindingContext = this;

            listMovieModels = new List<MoviesModel>
            {
                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                                new MoviesModel
                {
                    MoviesTitle = "Video 2",
                    MoviesAuthor = "FedEx",
                    MoviesView = 554,
                    MoviesUploadDate = new DateTime(2017, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate= new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate= new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "09R8_2nJtjg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                 new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                },
                new MoviesModel
                {
                    MoviesTitle = "pears",
                    MoviesAuthor = "FedEx",
                    MoviesView = 12345,
                    MoviesUploadDate = new DateTime(2000, 1, 23),
                    MoviesImageUrl = "me_photo.png",
                    MoviesUrl = "hhT_nvWreIhg"
                }
            };
            listViewMovies.ItemsSource = listMovieModels;
        }

        private void onMoviesTextChanged(object sender, TextChangedEventArgs e)
        {
            var keyword = moviesSearch.Text;
            var newMovieList = listMovieModels.Where(movie => movie.MoviesTitle.ToLower().Contains(keyword.ToLower()));
            listViewMovies.ItemsSource = newMovieList;
        }

        private void onMoviesSearchButton(object sender, EventArgs e) { }

        private void onSelectedVideo(object sender, SelectedItemChangedEventArgs e)
        {
            ListView listVideo = (ListView)sender;

            if (e.SelectedItem != null)
            {
                var selectedMoviesModel = (MoviesModel)e.SelectedItem;
                CrossShare.Current.OpenBrowser(YouTubeUrl + selectedMoviesModel.MoviesUrl);
            }

            listVideo.SelectedItem = null;
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
                    getMoviesData();
                    IsRefreshing = false;
                });
            }
        }

        public void getMoviesData()
        {
            List<MoviesModel> listMovies = new List<MoviesModel>
            {
                new MoviesModel
                {
                MoviesTitle = "Video 2",
                MoviesAuthor = "FedEx",
                MoviesView = 554,
                MoviesUploadDate = new DateTime(2017, 1, 23),
                MoviesImageUrl = "me_photo.png",
                MoviesUrl = "8vHqe9JA1k0"
                },
                new MoviesModel
                {
                    MoviesTitle = "bananas",
                    MoviesAuthor = "meeks",
                    MoviesView = 23,
                    MoviesUploadDate = new DateTime(2012, 3, 11),
                    MoviesImageUrl = "icon.png",
                    MoviesUrl = "9I16FhnSa-c"
                },
                new MoviesModel
                {
                    MoviesTitle = "grapes",
                    MoviesAuthor = "fedex",
                    MoviesView = 211,
                    MoviesUploadDate = new DateTime(2013, 4, 13),
                    MoviesImageUrl = "doktor.png",
                    MoviesUrl = "qqob4D3BoZc"
                },
                new MoviesModel
                {
                    MoviesTitle = "Video 5",
                    MoviesAuthor = "Mike",
                    MoviesView = 12,
                    MoviesUploadDate = new DateTime(2010, 7, 11),
                    MoviesImageUrl = "katty.jpg",
                    MoviesUrl = "JGwWNGJdvx8"
                },
                new MoviesModel
                {
                    MoviesTitle = "PeARs",
                    MoviesAuthor = "JJEORF",
                    MoviesView = 2231,
                    MoviesUploadDate = new DateTime(2009, 5, 14),
                    MoviesImageUrl = "jeniffer.jpg",
                    MoviesUrl = "09R8_2nJtjg"
                }
            };

            listViewMovies.ItemsSource = listMovies;
        }
    }
}