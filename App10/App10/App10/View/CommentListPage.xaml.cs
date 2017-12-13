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
    public partial class CommentListPage : ContentPage
    {
        public CommentListPage()
        {
            InitializeComponent();
            this.Title = "Comment List Page";
            getInit();

        }

        private void getInit()
        {
            List<CommentModel> CommentList = new List<CommentModel>();

            CommentList.Add(new CommentModel
            {
                CommenId = 1,
                CommentUserName = "Amanda",
                CommentServiceName = "Laser Epilation",
                CommentStar = "7/10 Imd",
                CommentDesc = "I was extremely worried when I went with the reason of my health problem. After examining himself and examining the outcome of mr, he patronized me so brightly that I was scared of the hospital and left peacefully. Besides being a good physician, he is compassionate and he is empathy with his patient. I thank Dr Erhan Bey and your patient.",
                CommentDate = new DateTime(2017, 8, 25), 
                CommentImageUrl = "katty.jpg"
            });

            CommentList.Add(new CommentModel
            {
                CommenId = 2,
                CommentUserName = "Cassandra",
                CommentServiceName = "Filling Injection",
                CommentStar = "8/10 Imd",
                CommentDesc = "I was extremely worried when I went with the reason of my health problem. After examining himself and examining the outcome of mr, he patronized me so brightly that I was scared of the hospital and left peacefully. Besides being a good physician, he is compassionate and he is empathy with his patient. I thank Dr Erhan Bey and your patient.",
                CommentDate = new DateTime(2017, 8, 22),
                CommentImageUrl = "jeniffer.jpg"
            });

            CommentListView.BindingContext = CommentList;
        }

        private void onSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ListView listViewComments = (ListView)sender;

            if (e.SelectedItem != null)
            {
                var selectedComments = (CommentModel)e.SelectedItem;
                Navigation.PushAsync(new CommentDetailPage(selectedComments));
            }

            listViewComments.SelectedItem = null;
        }
    }
}