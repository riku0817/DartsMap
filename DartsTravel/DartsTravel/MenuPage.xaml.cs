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
            haikei.Source = ImageSource.FromResource("DartsTravel.Image.hatena.png");
            tuuti.Source = ImageSource.FromResource("DartsTravel.Image.kadomaru.png");

        }

        int flickcount = 0;
        bool flickbool = true;
        bool kakutei = true;
        private async void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
        {
            //kakudarts.Scale = 2.5;
                dartskamae.IsEnabled = false;
            Random r = new Random();
            int kakuritu = r.Next(0,5);

            //kakuritu = 1;
            if (kakuritu == 1 && flickcount == 0)   //ダーツが外れる確定演出
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

                    //for (int i = 0; i < 40; i++)
                    //{

                        //otiru.TranslationY += 15;
                        //await Task.Delay(10);
                    //}

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
                    DartsStart.TranslationY += 400;   //もう一回のラベルをずらす
                    DartsStart.Text = "もう一回！";
                    tyuuigaki.TranslationY -= 1000;
                    kakudarts.Scale = 0; 
                    kakudarts.TranslationX = 0;
                    kakudarts.TranslationY = 590;
                    otiru.Scale = 0;
                    otiru.TranslationX = 100;
                    otiru.TranslationY = 200;

                    dartskamae.IsEnabled = true;

                    //dartskamae.TranslationX -= 100;
                    //dartskamae.TranslationY += 200;
                    //dartskamae.Scale = dartskamae.Scale + 0.9;
                }
                await Task.Delay(200);
                dartskamae.IsEnabled = true;
                flickbool = true;

            }
            else if (kakuritu == 2&& flickcount == 0)   //確定通知
            {
                if (flickbool == true)
                {
                    flickbool = false;

                    DartsStart.TranslationY -= 200;
                    tyuuigaki.TranslationY -= 200;

                    for (int i = 0; i < 60; i++)
                    {
                        if (tuuti.TranslationY >= -280)
                        {
                            tuuti.TranslationY = -280;
                        }
                        else if(tuuti.TranslationY < -280)
                        {
                            tuuti.TranslationY += 15;
                        }
                        dartskamae.TranslationY -= 3.5;
                        dartskamae.Scale = dartskamae.Scale - 0.015;
                        await Task.Delay(30);
                        
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        tuuti.TranslationY -= 15;
                        await Task.Delay(30);
                    }
                    if (tuuti.TranslationY != -455)
                    {
                        tuuti.TranslationY = -455;
                    }
                    DartsStart.TranslationY += 200;
                    tyuuigaki.TranslationY += 200;
                    await Navigation.PushModalAsync(new NavigationPage(new nishigou()));
                    dartskamae.TranslationY += 210;
                    dartskamae.Scale = dartskamae.Scale + 0.9;

                    dartskamae.IsEnabled = true;
                    flickbool = true;

                }
            }
            else     //通常演出
            {
                if (flickbool == true)
                {
                    flickbool = false;
                    for (int i = 0; i < 10; i++)   //ダーツが刺さる処理
                    {
                        dartskamae.TranslationY -= 20;
                        dartskamae.Scale = dartskamae.Scale - 0.09;
                        await Task.Delay(30);
                    }
                    
                    if (flickcount == 1)     //ダーツが外れる確定演出の時の遷移
                    {
                        await Navigation.PushModalAsync(new NavigationPage(new nishigou()));
                        dartskamae.TranslationY += 200;
                        dartskamae.Scale = dartskamae.Scale + 0.9;
                        flickcount = 0;
                        DartsStart.TranslationY -= 400;
                        tyuuigaki.TranslationY += 1000;
                        DartsStart.Text = "ダーツを投げよう！";
                    }
                    else    //通常演出の時の遷移
                    {
                        await Navigation.PushModalAsync(new NavigationPage(new MainPage()));
                        dartskamae.TranslationY += 200;
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