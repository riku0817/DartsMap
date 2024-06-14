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
            dartskamae.Source = ImageSource.FromResource("DartsTravel.Image.darts.png");
        }


        bool flickbool = true;
        private async void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
        {
            
                dartskamae.IsEnabled = false;
                if (flickbool == true)
                {
                    flickbool = false;
                for (int i = 0; i < 10; i++)
                {
                    dartskamae.TranslationY -= 18;
                    dartskamae.Scale = dartskamae.Scale - 0.26;
                    await Task.Delay(30);
                }
                    await Navigation.PushModalAsync(new MainPage());
                   dartskamae.TranslationY += 180;
                   dartskamae.Scale = dartskamae.Scale + 2.6;
                }
            
            await Task.Delay(200);
            dartskamae.IsEnabled = true;
            flickbool = true;
        }
    }
}