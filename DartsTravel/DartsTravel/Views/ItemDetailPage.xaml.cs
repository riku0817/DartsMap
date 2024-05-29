using DartsTravel.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DartsTravel.Views
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