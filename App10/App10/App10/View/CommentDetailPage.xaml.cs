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
    public partial class CommentDetailPage : ContentPage
    {
        public CommentDetailPage(CommentModel commentModel)
        {
            InitializeComponent();
            BindingContext = commentModel;

            ButtonLike.Clicked += (sender, args) => {
                ButtonLike.Image = "ic_favorite_white_24dp.png";
            };

            ButtonShare.Clicked += (sender, args) => {
                DisplayAlert("Success", "Share", "Ok", "Cancel");
            };
        }
    }
}