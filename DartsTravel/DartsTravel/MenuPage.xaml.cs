using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DartsTravel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            dartskamae.Source = ImageSource.FromResource("DartsTravel.Image.dartskamae.jpg");
        }


        bool flickbool = true;
        private async void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
        {
            dartskamae.IsEnabled = false;
            if (flickbool == true)
            {
                flickbool = false;
                await Navigation.PushModalAsync(new MainPage());
            }
            await Task.Delay(200);
            dartskamae.IsEnabled = true;
            flickbool = true;
        }
    }
}