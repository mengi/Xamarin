using App10.Model;
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
    public partial class FavoriteItemModel : ViewCell
    {
        private CardDataAnnuoncModel dataAnnuoncModel;
        public FavoriteItemModel()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            dataAnnuoncModel = BindingContext as CardDataAnnuoncModel;
        }
    }
}