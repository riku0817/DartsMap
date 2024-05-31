using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace DartsTravel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        double x;
        double y;

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Random r = new Random();
            int random1 = r.Next(1,47);


            

            try
            {



                switch (random1)
                {
                    case 1:
                        x = 43.46722;
                        y = 142.8278;
                        
                        break;

                    case 2:
                        x = 40.78028;
                        y = 140.8319;
                        
                        break;

                    case 3:
                        x = 39.59139;
                        y = 141.3625;
                        
                        break;

                    case 4:
                        x = 38.44556;
                        y = 140.9281;
                        
                        break;

                    case 5:
                        x = 39.7475;
                        y = 140.4086;
                        
                        break;

                    case 6:
                        x = 38.44639;
                        y = 140.1028;
                        
                        break;

                    case 7:
                        x = 37.37889;
                        y = 140.2253;
                        
                        break;

                    case 8:
                        x = 36.30639;
                        y = 140.3186;
                        
                        break;

                    case 9:
                        x = 36.68917;
                        y = 139.8192;
                        
                        break;

                    case 10:
                        x = 36.50389;
                        y = 138.9853;
                        
                        break;

                    case 11:
                        x = 35.99667;
                        y = 139.3478;
                        
                        break;

                    case 12:
                        x = 35.51278;
                        y = 140.2039;
                        
                        break;

                    case 13:
                        x = 35.01833;
                        y = 139.5986;
                        
                        break;

                    case 14:
                        x = 35.41417;
                        y = 139.3403;
                        
                        break;

                    case 15:
                        x = 37.51889;
                        y = 138.9172;
                        
                        break;

                    case 16:
                        x = 36.63611;
                        y = 137.2681;
                        
                        break;

                    case 17:
                        x = 36.76583;
                        y = 136.7714;
                        
                        break;

                    case 18:
                        x = 35.84667;
                        y = 136.2272;
                        
                        break;

                    case 19:
                        x = 35.61222;
                        y = 138.6117;
                        
                        break;

                    case 20:
                        x = 36.13;
                        y = 138.0439;
                        
                        break;

                    case 21:
                        x = 35.7775;
                        y = 137.055;
                        
                        break;

                    case 22:
                        x = 35.01694;
                        y = 138.33;
                        
                        break;

                    case 23:
                        x = 35.03444;
                        y = 137.215;
                        
                        break;

                    case 24:
                        x = 34.51361;
                        y = 136.3814;
                        
                        break;

                    case 25:
                        x = 35.21528;
                        y = 136.1381;
                        
                        break;

                    case 26:
                        x = 35.25194;
                        y = 135.4458;
                        
                        break;

                    case 27:
                        x = 34.62278;
                        y = 135.5111;
                        
                        break;

                    case 28:
                        x = 35.03694;
                        y = 134.8286;
                        
                        break;

                    case 29:
                        x = 34.31556;
                        y = 135.8714;
                        
                        break;

                    case 30:
                        x = 33.90944;
                        y = 135.5133;
                        
                        break;

                    case 31:
                        x = 35.36056;
                        y = 133.8517;
                        
                        break;

                    case 32:
                        x = 35.07306;
                        y = 132.5594;
                        
                        break;

                    case 33:
                        x = 34.90083;
                        y = 133.8153;
                        
                        break;

                    case 34:
                        x = 34.60361;
                        y = 132.7875;
                        
                        break;

                    case 35:
                        x = 34.19861;
                        y = 131.575;
                        
                        break;

                    case 36:
                        x = 33.91806;
                        y = 134.2431;
                        
                        break;

                    case 37:
                        x = 34.24306;
                        y = 133.9967;
                        
                        break;

                    case 38:
                        x = 33.62194;
                        y = 132.8558;
                        
                        break;

                    case 39:
                        x = 33.42111;
                        y = 133.3667;
                        
                        break;

                    case 40:
                        x = 33.5225;
                        y = 130.6681;
                        
                        break;

                    case 41:
                        x = 33.28528;
                        y = 130.1169;
                        
                        break;

                    case 42:
                        x = 33.2275;
                        y = 129.6142;
                        
                        break;

                    case 43:
                        x = 32.615;
                        y = 130.7564;
                        
                        break;

                    case 44:
                        x = 33.19917;
                        y = 131.4342;
                        
                        break;

                    case 45:
                        x = 32.19083;
                        y = 131.3006;
                        
                        break;

                    case 46:
                        x = 31.01278;
                        y = 130.4242;
                        
                        break;

                    case 47:
                        x = 25.77111;
                        y = 126.64;
                        
                        break;

                }
                MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(x, y), Distance.FromKilometers(100)));
            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

            //try
            //{
            //東京へ移動させる
            //MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(x, y), Distance.FromKilometers(100)));
            //}
            // catch (Exception ex)
            //{
            // Debug.WriteLine(ex);
            //}
        }
    }
}
