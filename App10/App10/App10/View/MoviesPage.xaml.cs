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
    public partial class MoviesPage : ContentPage
    {
        public MoviesPage()
        {
            InitializeComponent();
            List<CardDataMoviesModel> listMovies = new List<CardDataMoviesModel>();

            listMovies.Add(new CardDataMoviesModel
            {
                MoviesId = 1,
                MoviesTitle = "Android Authority",
                MoviesDesc = "Things you should always automate on ad ad ad adas dad ad ad ad sfsg gsfdgaeqwewqdayour phonea ad asda dad asd ada dad ad ad ad ad ad ad ad adadad",
                MoviesViews = 10854,
                MoviesUploadDate = "2017-11-25",
                MoviesImageUrl = "doktor.png"
            });

            listMovies.Add(new CardDataMoviesModel
            {
                MoviesId = 1,
                MoviesTitle = "The Indipendendent",
                MoviesDesc = "Game of THrones season 7 : Fans think Catelyn's Stark's Ghost was asd ad ad ad ad ada dsad ad ada dada d ad adaads ",
                MoviesViews = 112598,
                MoviesUploadDate = "2017-11-26",
                MoviesImageUrl = "doktor.png"
            });

            lstMovies.BindingContext = listMovies;
        }
    }
}