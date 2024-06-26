﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Net.NetworkInformation;
using Xamarin.Essentials;
using System.Threading;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace DartsTravel
{
    public partial class nishigou : ContentPage
    {
        MyViewModel viewModel;
        static readonly HttpClient client = new HttpClient();
        static int x_natural;
        static int y_natural;
        static int x_double;
        static int y_double;
        static int todoufuken;
        static Random r = new Random();
        Pin pin = new Pin();
        string locationName;
        string locationProperty;
        bool shiteimode;
        bool isReload = true;


        public nishigou()
        {
            InitializeComponent();
            viewModel = new MyViewModel();
            BindingContext = viewModel;
            mapdarts.Source = ImageSource.FromResource("DartsTravel.Image.darts.png");
            MyMap.UiSettings.ZoomControlsEnabled = true;
            MyMap.UiSettings.ScrollGesturesEnabled = false;
        }

        double x;
        double y;

        bool kakuritu = true;

        
        protected override async void OnAppearing()
        {
            if (isReload == true)
            {
                base.OnAppearing();



                if (kakuritu == true)
                {

                }

                todoufuken = r.Next(1, 47);



                switch (todoufuken)
                {
                    case 1://北海道 
                        x_natural = 41;
                        y_natural = 139;
                        break;
                    case 2://青森 
                        x_natural = 40;
                        y_natural = 140;
                        break;
                    case 3://岩手 
                        x_natural = 39;
                        y_natural = 141;
                        break;
                    case 4://宮城
                        x_natural = 38;
                        y_natural = 140;
                        break;
                    case 5://秋田 
                        x_natural = 39;
                        y_natural = 140;
                        break;
                    case 6://山形
                        x_natural = 38;
                        y_natural = 140;
                        break;
                    case 7://福島 
                        x_natural = 37;
                        y_natural = 140;
                        break;
                    case 8://茨城 
                        x_natural = 36;
                        y_natural = 140;
                        break;
                    case 9://栃木 
                        x_natural = 36;
                        y_natural = 139;
                        break;
                    case 10://群馬 
                        x_natural = 36;
                        y_natural = 139;
                        break;
                    case 11://埼玉 
                        x_natural = 35;
                        y_natural = 139;
                        break;
                    case 12://千葉 
                        x_natural = 35;
                        y_natural = 140;
                        break;
                    case 13://東京 
                        x_natural = 35;
                        y_natural = 139;
                        break;
                    case 14://神奈川 
                        x_natural = 35;
                        y_natural = 139;
                        break;
                    case 15://新潟 
                        x_natural = 37;
                        y_natural = 139;
                        break;
                    case 16://富山 
                        x_natural = 36;
                        y_natural = 137;
                        break;
                    case 17://石川 
                        x_natural = 36;
                        y_natural = 136;
                        break;
                    case 18://福井 
                        x_natural = 36;
                        y_natural = 136;
                        break;
                    case 19://山梨 
                        x_natural = 35;
                        y_natural = 138;
                        break;
                    case 20://長野 
                        x_natural = 36;
                        y_natural = 138;
                        break;
                    case 21://岐阜
                        x_natural = 35;
                        y_natural = 136;
                        break;
                    case 22://静岡
                        x_natural = 34;
                        y_natural = 138;
                        break;
                    case 23://愛知
                        x_natural = 35;
                        y_natural = 136;
                        break;
                    case 24://三重
                        x_natural = 34;
                        y_natural = 136;
                        break;
                    case 25://滋賀
                        x_natural = 35;
                        y_natural = 135;
                        break;
                    case 26://京都
                        x_natural = 35;
                        y_natural = 135;
                        break;
                    case 27://大阪
                        x_natural = 34;
                        y_natural = 135;
                        break;
                    case 28://兵庫
                        x_natural = 34;
                        y_natural = 135;
                        break;
                    case 29://奈良
                        x_natural = 34;
                        y_natural = 135;
                        break;
                    case 30://和歌山
                        x_natural = 34;
                        y_natural = 135;
                        break;
                    case 31://鳥取
                        x_natural = 35;
                        y_natural = 134;
                        break;
                    case 32://島根
                        x_natural = 35;
                        y_natural = 134;
                        break;
                    case 33://岡山
                        x_natural = 34;
                        y_natural = 133;
                        break;
                    case 34://広島
                        x_natural = 34;
                        y_natural = 132;
                        break;
                    case 35://山口
                        x_natural = 34;
                        y_natural = 131;
                        break;
                    case 36://徳島
                        x_natural = 34;
                        y_natural = 134;
                        break;
                    case 37://香川
                        x_natural = 34;
                        y_natural = 134;
                        break;
                    case 38://愛媛
                        x_natural = 33;
                        y_natural = 132;
                        break;
                    case 39://高知
                        x_natural = 33;
                        y_natural = 133;
                        break;
                    case 40://福岡
                        x_natural = 33;
                        y_natural = 130;
                        break;
                    case 41://佐賀
                        x_natural = 33;
                        y_natural = 130;
                        break;
                    case 42://長崎
                        x_natural = 32;
                        y_natural = 129;
                        break;
                    case 43://熊本
                        x_natural = 32;
                        y_natural = 130;
                        break;
                    case 44://大分
                        x_natural = 33;
                        y_natural = 131;
                        break;
                    case 45://宮崎
                        x_natural = 31;
                        y_natural = 131;
                        break;
                    case 46://鹿児島
                        x_natural = 31;
                        y_natural = 130;
                        break;
                    case 47://沖縄
                        x_natural = 26;
                        y_natural = 127;
                        break;
                }
                bool isSearch = true;

                int searchcount = 0;





                while (isSearch == true)
                {
                    searchcount += 1;

                    


                    try
                    {
                        MyMap.Pins.Clear();
                        x_double = r.Next(000001, 999999);
                        y_double = r.Next(000001, 999999);

                        string x_string = x_natural + "." + x_double;
                        string y_string = y_natural + "." + y_double;


                        x = 37.109897;
                        y = 140.152712;



                        string apiUrl = $"https://map.yahooapis.jp/geoapi/V1/reverseGeoCoder?output=json&lat=37.109897&lon=140.152712&appid=dj00aiZpPTFXSWpmaHFZZ0YxSSZzPWNvbnN1bWVyc2VjcmV0Jng9ZTI-";


                        // APIからのレスポンスを取得
                        HttpResponseMessage response = await client.GetAsync(apiUrl);
                        response.EnsureSuccessStatusCode();
                        string decoderjson = await response.Content.ReadAsStringAsync();

                        JObject decoderData = JObject.Parse(decoderjson);

                        if (decoderjson.Contains("\"Address\":\"\"") == true)
                        {
                            // 海なので再抽選
                        }
                        else
                        {
                            isSearch = false;



                            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(x, y), Distance.FromKilometers(1000)));

                            for (int i = 0; i < 10; i++)
                            {
                                mapdarts.TranslationY -= 51;
                                mapdarts.Scale = mapdarts.Scale - 0.26;
                                await Task.Delay(30);
                            }
                            await Task.Delay(1000);


                            if (shiteimode == false)
                            {
                                locationName = (string)decoderData["Feature"][0]["Property"]["AddressElement"][0]["Name"] +
                                    (string)decoderData["Feature"][0]["Property"]["AddressElement"][1]["Name"];

                                locationProperty = (string)decoderData["Feature"][0]["Property"]["AddressElement"][2]["Name"] +
                                    (string)decoderData["Feature"][0]["Property"]["AddressElement"][3]["Name"];

                      

                                
                                MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(x, y), Distance.FromKilometers(10)));

                            }
                            isReload = false;

                            LabelText.Text = "福島県西白河郡西郷村\n" + "(クリックで観光地検索)";


                        }
                    }

                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex);
                    }

                    // デバッグ用検索回数表示
                    searchcountlabel.Text = "検索回数" + searchcount;
                }
            }
        }

        static int click;


     

        private void Location_Clicked(object sender, EventArgs e)
        {
            Launcher.OpenAsync($"https://www.google.co.jp/search?q=福島県西白河郡西郷村 観光地&mobile_link");

        }

        private void MapAppButton_Clicked(object sender, EventArgs e)
        {
            Launcher.OpenAsync($"https://www.google.com/maps/search/?api=1&query=37.109897,140.152712");
        }


        private void Google_Clicked(object sender, EventArgs e)
        {
            Launcher.OpenAsync($"https://www.google.com/maps/search/?api=1&query=37.109897,140.152712");
        }
    }
}
