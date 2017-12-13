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
    public partial class SubCategoryDetailPage : ContentPage
    {
        SubCategoryModel subCategoryModel;
        public SubCategoryDetailPage(SubCategoryModel subModel)
        {
            this.Title = subModel.subTitle;
            InitializeComponent();
            subCategoryModel = subModel;
            BindingContext = subModel;

            ButtonShare.Clicked += async (sender, args) => {
                Button btnShare = (Button)sender;

                ShareMessage message = new ShareMessage();
                message.Title = subCategoryModel.subTitle;
                message.Text = subCategoryModel.subDesc;
                message.Url = subCategoryModel.subImageUrl;
                await CrossShare.Current.Share(message);
            };
        }
    }
}