using System;
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

                string shitei = locationpicker.Items[locationpicker.SelectedIndex];

                if (kakuritu == true)
                {

                }

                todoufuken = r.Next(1, 47);

                switch (shitei)
                {
                    case "都道府県すべて":
                        break;
                    case "北海道":
                        todoufuken = 1;
                        break;
                    case "青森県":
                        todoufuken = 2;
                        break;
                    case "岩手県":
                        todoufuken = 3;
                        break;
                    case "宮城県":
                        todoufuken = 4;
                        break;
                    case "秋田県":
                        todoufuken = 5;
                        break;
                    case "山形県":
                        todoufuken = 6;
                        break;
                    case "福島県":
                        todoufuken = 7;
                        break;
                    case "茨城県":
                        todoufuken = 8;
                        break;
                    case "栃木県":
                        todoufuken = 9;
                        break;
                    case "群馬県":
                        todoufuken = 10;
                        break;
                    case "埼玉県":
                        todoufuken = 11;
                        break;
                    case "千葉県":
                        todoufuken = 12;
                        break;
                    case "東京都":
                        todoufuken = 13;
                        break;
                    case "神奈川県":
                        todoufuken = 14;
                        break;
                    case "新潟県":
                        todoufuken = 15;
                        break;
                    case "富山県":
                        todoufuken = 16;
                        break;
                    case "石川県":
                        todoufuken = 17;
                        break;
                    case "福井県":
                        todoufuken = 18;
                        break;
                    case "山梨県":
                        todoufuken = 19;
                        break;
                    case "長野県":
                        todoufuken = 20;
                        break;
                    case "岐阜県":
                        todoufuken = 21;
                        break;
                    case "静岡県":
                        todoufuken = 22;
                        break;
                    case "愛知県":
                        todoufuken = 23;
                        break;
                    case "三重県":
                        todoufuken = 24;
                        break;
                    case "滋賀県":
                        todoufuken = 25;
                        break;
                    case "京都府":
                        todoufuken = 26;
                        break;
                    case "大阪府":
                        todoufuken = 27;
                        break;
                    case "兵庫県":
                        todoufuken = 28;
                        break;
                    case "奈良県":
                        todoufuken = 29;
                        break;
                    case "和歌山県":
                        todoufuken = 30;
                        break;
                    case "鳥取県":
                        todoufuken = 31;
                        break;
                    case "島根県":
                        todoufuken = 32;
                        break;
                    case "岡山県":
                        todoufuken = 33;
                        break;
                    case "広島県":
                        todoufuken = 34;
                        break;
                    case "山口県":
                        todoufuken = 35;
                        break;
                    case "徳島県":
                        todoufuken = 36;
                        break;
                    case "香川県":
                        todoufuken = 37;
                        break;
                    case "愛媛県":
                        todoufuken = 38;
                        break;
                    case "高知県":
                        todoufuken = 39;
                        break;
                    case "福岡県":
                        todoufuken = 40;
                        break;
                    case "佐賀県":
                        todoufuken = 41;
                        break;
                    case "長崎県":
                        todoufuken = 42;
                        break;
                    case "熊本県":
                        todoufuken = 43;
                        break;
                    case "大分県":
                        todoufuken = 44;
                        break;
                    case "宮崎県":
                        todoufuken = 45;
                        break;
                    case "鹿児島県":
                        todoufuken = 46;
                        break;
                    case "沖縄県":
                        todoufuken = 47;
                        break;

                }

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

                    // 北海道、鹿児島、沖縄の検索補助
                    if (todoufuken == 1)
                    {
                        x_natural = r.Next(41, 45);
                        y_natural = r.Next(139, 144);
                    }
                    else if (todoufuken == 46)
                    {
                        int kagoshimaproperty = r.Next(1, 4);
                        switch (kagoshimaproperty)
                        {
                            case 1:
                                x_natural = 31;
                                y_natural = 130;
                                break;
                            case 2:
                                x_natural = 30;
                                y_natural = 130;
                                break;
                            case 3:
                                x_natural = 29;
                                y_natural = 129;
                                break;
                            case 4:
                                x_natural = 27;
                                y_natural = 128;
                                break;
                        }
                    }
                    else if (todoufuken == 47)
                    {
                        y_natural = r.Next(127, 128);
                    }



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

                            // 都道府県指定モード処理(処理激重の可能性)
                            if (shitei == "都道府県すべて")
                            {
                                shiteimode = false;
                                //すべてなので再抽選なし
                            }
                            else if (shitei != (string)decoderData["Feature"][0]["Property"]["AddressElement"][0]["Name"])
                            {
                                shiteimode = true;
                                isSearch = true;
                            }
                            else
                            {
                                shiteimode = false;
                            }

                            if (shiteimode == false)
                            {
                                MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(x, y), Distance.FromKilometers(1000)));
                                await Task.Delay(300);


                                locationName = (string)decoderData["Feature"][0]["Property"]["AddressElement"][0]["Name"] +
                                    (string)decoderData["Feature"][0]["Property"]["AddressElement"][1]["Name"];

                                locationProperty = (string)decoderData["Feature"][0]["Property"]["AddressElement"][2]["Name"] +
                                    (string)decoderData["Feature"][0]["Property"]["AddressElement"][3]["Name"];

                                pin = new Pin()
                                {

                                    Type = PinType.Place,
                                    Label = locationName,
                                    Address = locationProperty,
                                    Position = new Position(x, y),
                                    Rotation = -33.3f,//ピンを傾けることができる
                                    Tag = "",
                                };
                                MyMap.Pins.Add(pin);//マップへ追加




                                for (int i = 0; i < 10; i++)
                                {
                                    mapdarts.TranslationY -= 51;
                                    mapdarts.Scale = mapdarts.Scale - 0.26;
                                    await Task.Delay(30);
                                }
                                await Task.Delay(200);
                                MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(x, y), Distance.FromKilometers(100)));

                            }
                            isReload = false;

                            LabelText.Text = "福島県西白河郡西郷村" + "(クリックで観光地検索)";


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
