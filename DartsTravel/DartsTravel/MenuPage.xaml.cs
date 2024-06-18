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
        bool kakutei = true;
        private async void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
        {
            
                dartskamae.IsEnabled = false;
            Random r = new Random();
            int kakuritu = r.Next(0, 200);
            if (kakuritu == 1)
            {
                if (flickbool == true)
                {
                    flickbool = false;
                    for (int i = 0; i < 10; i++)
                    {
                        dartskamae.TranslationX += 10;
                        dartskamae.TranslationY -= 40;
                        dartskamae.Scale = dartskamae.Scale - 0.26;
                        await Task.Delay(30);
                    }
                    await Navigation.PushAsync(new nishigou());
                    dartskamae.TranslationX -= 100;
                    dartskamae.TranslationY += 400;
                    dartskamae.Scale = dartskamae.Scale + 2.6;
                }
                    await Navigation.PushAsync(new NavigationPage(new MainPage()));
                   dartskamae.TranslationY += 180;
                   dartskamae.Scale = dartskamae.Scale + 2.6;

                await Task.Delay(200);
                dartskamae.IsEnabled = true;
                flickbool = true;
            }
            else
            {
                if (flickbool == true)
                {
                    flickbool = false;
                    for (int i = 0; i < 10; i++)
                    {
                        dartskamae.TranslationY -= 18;
                        dartskamae.Scale = dartskamae.Scale - 0.26;
                        await Task.Delay(30);
                    }
                    await Navigation.PushModalAsync(new NavigationPage(new MainPage()));
                    dartskamae.TranslationY += 180;
                    dartskamae.Scale = dartskamae.Scale + 2.6;
                }

                await Task.Delay(200);
                dartskamae.IsEnabled = true;
                flickbool = true;
            }
        }
    }
}