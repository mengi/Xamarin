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
    public partial class MyEventItemModel : ViewCell
    {
        private RequestUserModel requestUserModel;
        public MyEventItemModel()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            requestUserModel = BindingContext as RequestUserModel;

            List<string> imageValues = (from image in App.listSubImage where image.Key == Convert.ToInt32(requestUserModel.reUserService) select image.Value).ToList();
            List<string> nameValues = (from name in App.listSubName where name.Key == Convert.ToInt32(requestUserModel.reUserService) select name.Value).ToList();

            requestImageUrl.Source = imageValues[0].ToString();
            requestServiceName.Text = nameValues[0].ToString();

            if (requestUserModel.reState == 0)
            {
                boxViewEvent.Color = Color.FromHex("#FFEB3B");
                requestState.Text = "Waiting";
            }

           
            if (requestUserModel.reState == 1)
            {
                boxViewEvent.Color = Color.FromHex("#2E7D32");
                requestState.Text = "Notified";
            }

       
            if (requestUserModel.reState == 2)
            {
                boxViewEvent.Color = Color.FromHex("#D84315");
                requestState.Text = "Past";
            }
        }
    }
}