using mobile_train.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace mobile_train.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}