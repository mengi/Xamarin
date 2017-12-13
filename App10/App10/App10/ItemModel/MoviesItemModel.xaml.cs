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
    public partial class MoviesItemModel : ViewCell
    {
        private CardDataMoviesModel dataMoviesModel;
        public MoviesItemModel()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            dataMoviesModel = BindingContext as CardDataMoviesModel;
        }
    }
}