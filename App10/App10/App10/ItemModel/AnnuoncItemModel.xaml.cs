using App10.Model;
using App10.View;
using Plugin.Share;
using Plugin.Share.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App10.ItemModel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnnuoncItemModel : ViewCell
    {
        private CardDataAnnuoncModel dataAnnuoncModel;
        private  string Url = "http://www.iqturkey.com/";
        public AnnuoncItemModel()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            dataAnnuoncModel = BindingContext as CardDataAnnuoncModel;
        }

        private async void onShare(object sender, EventArgs args)
        {
            ShareMessage message = new ShareMessage();
            message.Title = dataAnnuoncModel.HeadLines;
            message.Text = dataAnnuoncModel.HeadLinesDesc;
            message.Url = "";
            await CrossShare.Current.Share(message);
        }

        private void onVisibility(object sender, EventArgs args)
        {
            App.Current.MainPage.Navigation.PushAsync(new AnnouncDetailPage(dataAnnuoncModel, (int)App.AnnuncType.ANNUONCNORMAL));
        }
    }
}