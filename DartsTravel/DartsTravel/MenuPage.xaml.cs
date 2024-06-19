using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.Xaml;

namespace DartsTravel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            dartskamae.Source = ImageSource.FromResource("DartsTravel.Image.dartskirinuki.png");
            kakudarts.Source = ImageSource.FromResource("DartsTravel.Image.kakudarts.png");
            otiru.Source = ImageSource.FromResource("DartsTravel.Image.otirudarts.png");
            haikei.Source = ImageSource.FromResource("DartsTravel.Image.haikei.png");

        }

        int flickcount = 0;
        bool flickbool = true;
        bool kakutei = true;
        private async void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
        {
            //kakudarts.Scale = 2.5;
                dartskamae.IsEnabled = false;
            Random r = new Random();
            int kakuritu = r.Next(0,200);

            kakuritu = 1;
            //kakuritu = 1;
            if (kakuritu == 1 && flickcount == 0)
            {
                if (flickbool == true)
                {
                    flickbool = false;

                    kakudarts.Scale = 2.5;
                    for (int i = 0; i < 10; i++) 
                    {
                        dartskamae.Scale = 0;
                        kakudarts.Scale -= 0.2;
                        kakudarts.TranslationX += 10;
                        kakudarts.TranslationY -= 30;
                        //dartskamae.TranslationX += 10;
                        //dartskamae.TranslationY -= 40;
                        //dartskamae.Scale = dartskamae.Scale - 0.09;
                        await Task.Delay(30);
                    }
                    await Task.Delay(300);
                    for (int i = 0; i < 10; i++)
                    {
                        kakudarts.Scale = 0;
                        otiru.Scale = 0.5;
                        otiru.TranslationY = otiru.TranslationY + 20 + 5;
                        //kakudarts.TranslationY += 20;
                        //dartskamae.TranslationY += 20;
                        await Task.Delay(30);
                    }

                    for (int i = 0; i < 40; i++)
                    {

                        otiru.TranslationY += 15;
                        await Task.Delay(10);
                    }

                    for (int i = 0; i < 5; i++)
                    {

                        otiru.TranslationY -= 5;
                        await Task.Delay(30);
                    }

                    for (int i = 0; i < 5; i++)
                    {

                        otiru.TranslationY += 5;
                        await Task.Delay(30);
                    }
                    await Task.Delay(400);
                    otiru.Scale = 0;



                    dartskamae.TranslationX = 100;
                    dartskamae.TranslationY = 100;
                    dartskamae.Scale = 0;

                    for (int i = 0; i < 10; i++)
                    {
                        dartskamae.TranslationX -= 10;
                        dartskamae.TranslationY += 30;
                        dartskamae.Scale += 0.1;
                        await Task.Delay(30);
                    }

                    flickcount = flickcount + 1;
                    kakudarts.Scale = 0; 
                    kakudarts.TranslationX = 0;
                    kakudarts.TranslationY = 290;
                    otiru.Scale = 0;
                    otiru.TranslationX = 100;
                    otiru.TranslationY = -200;

                    dartskamae.IsEnabled = true;

                    //dartskamae.TranslationX -= 100;
                    //dartskamae.TranslationY += 200;
                    //dartskamae.Scale = dartskamae.Scale + 0.9;
                }
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
                        dartskamae.Scale = dartskamae.Scale - 0.09;
                        await Task.Delay(30);
                    }
                    
                    if (flickcount == 1)
                    {
                        await Navigation.PushModalAsync(new NavigationPage(new nishigou()));
                        dartskamae.TranslationY += 180;
                        dartskamae.Scale = dartskamae.Scale + 0.9;
                        flickcount = 0;
                    }
                    else
                    {
                        await Navigation.PushModalAsync(new NavigationPage(new MainPage()));
                        dartskamae.TranslationY += 180;
                        dartskamae.Scale = dartskamae.Scale + 0.9;
                    }
                }

                await Task.Delay(200);
                dartskamae.IsEnabled = true;
                flickbool = true;
            }
        }
    }
}