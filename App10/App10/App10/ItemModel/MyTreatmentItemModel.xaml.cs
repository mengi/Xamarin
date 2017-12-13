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
    public partial class MyTreatmentItemModel : ViewCell
    {
        private TreatmentModel treatmentModel;
        public MyTreatmentItemModel()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            treatmentModel = BindingContext as TreatmentModel;
        }
    }
}