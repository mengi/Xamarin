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
    public partial class MyTreatmentPage : ContentPage
    {
        private List<TreatmentModel> listTreatments;
        public MyTreatmentPage(UserModel userModel)
        {
            InitializeComponent();
            this.Title = "My Treatment";
            BindingContext = this;
            getDateTreatment(userModel);
        }

        public void getDateTreatment(UserModel user)
        {
            listTreatments = new List<TreatmentModel>();
            listTreatments.Add(new TreatmentModel
            {
                userId = 1,
                treatmentTitle = "Yüz ve Dudak Dolgusu",
                treatmentDate = new DateTime(2017, 12, 04),
                treatmentImageUrl = "dolgu.jgp"
            });

            listTreatments.Add(new TreatmentModel
            {
                userId = 1,
                treatmentTitle = "Fraksiyonel CO2 Lazer",
                treatmentDate = new DateTime(2017, 11, 04),
                treatmentImageUrl = "leke.jpg"
            });

            listTreatments.Add(new TreatmentModel
            {
                userId = 2,
                treatmentTitle = "Selülit Tedavisi",
                treatmentDate = new DateTime(2017, 10, 14),
                treatmentImageUrl = "selulit.jpg"
            });

            listTreatments.Add(new TreatmentModel
            {
                userId = 2,
                treatmentTitle = "Kalıcı Makyaj",
                treatmentDate = new DateTime(2017, 10, 12),
                treatmentImageUrl = "kalici_makyaj.jpg"
            });

            myTreatmentListView.BindingContext = listTreatments.Where(Model => Model.userId == user.userId);
        }

        private void onSelectedTreatment(object sender, SelectedItemChangedEventArgs e)
        {
            ListView listViewTreatment = (ListView)sender;

            if (e.SelectedItem != null)
            {
                var TreatmentModel = (TreatmentModel)e.SelectedItem;
            }

            listViewTreatment.SelectedItem = null;
        }
    }
}