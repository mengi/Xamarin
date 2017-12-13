using App10.Model;
using Plugin.Share;
using Plugin.Share.Abstractions;
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
    public partial class AnnouncDetailPage : ContentPage
    {
        public AnnouncDetailPage(CardDataAnnuoncModel cardDataAnnuoncModel, int AnnuoncType)
        {
            InitializeComponent();
            this.Title = cardDataAnnuoncModel.HeadTitle;

            string Url = "http://www.iqturkey.com/";
            BindingContext = cardDataAnnuoncModel;

            if (App.favoriteAnnuoncList.Contains(cardDataAnnuoncModel))
            {
                ButtonLike.Image = "ic_favorite_white_24dp.png";
                AnnuoncType = 2;
            }

            ButtonLike.Clicked += (sender, args) =>
            {
                try
                {
                    if (AnnuoncType == 1)
                    {
                        App.favoriteAnnuoncList.Add(cardDataAnnuoncModel);
                        ButtonLike.Image = "ic_favorite_white_24dp.png";
                        AnnuoncType = 2;
                        return;
                    }
                    else if (AnnuoncType == 2)
                    {
                        App.favoriteAnnuoncList.Remove(cardDataAnnuoncModel);
                        ButtonLike.Image = "ic_favorite_border_white_24dp.png";
                        AnnuoncType = 1;
                        return;
                    }
                }
                catch (Exception e) { e.Message.ToString(); }

            };

            ButtonShare.Clicked += async (sender, args) =>
            {
                ShareMessage message = new ShareMessage();
                message.Title = cardDataAnnuoncModel.HeadLines;
                message.Text = cardDataAnnuoncModel.HeadLinesDesc;
                message.Url = Url;
                await CrossShare.Current.Share(message);
            };
        }

    }
}