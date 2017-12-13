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
    public partial class SubItemModel : ViewCell
    {

        private SubCategoryModel subCategoryModel;
        public SubItemModel()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            subCategoryModel = BindingContext as SubCategoryModel;
        }
    }
}