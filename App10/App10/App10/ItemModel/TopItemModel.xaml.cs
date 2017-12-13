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
    public partial class TopItemModel : ViewCell
    {
        private TopCategoryModel topCategoryModel;
        public TopItemModel()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            topCategoryModel = BindingContext as TopCategoryModel;
        }
    }
}