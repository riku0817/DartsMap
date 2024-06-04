using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static readonly HttpClient client = new HttpClient();
    static string apiUrl = "https://map.yahooapis.jp/geoapi/V1/reverseGeoCoder?output=json&lat=43.46722&lon=142.8278&appid=dj00aiZpPTFXSWpmaHFZZ0YxSSZzPWNvbnN1bWVyc2VjcmV0Jng9ZTI-";
    static int x_natural;
    static int y_natural;
    static int x_double;
    static int y_double;
    static int todoufuken;
    static Random r = new Random();

    static async Task Main()
    {
        bool isSearch = true;
        

        todoufuken = r.Next(1, 30);
        todoufuken = 47;
        switch (todoufuken)
        {
            case 1://北海道 
                x_natural = 43;
                y_natural = 141;
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
        Console.WriteLine(todoufuken);

        while (isSearch==true) 
        {

            


            try
            {
                


                

                x_double = r.Next(000001, 999999);
                y_double = r.Next(000001, 999999);

                


                //x = 37.784596;
                //y = 141.299904; //デバッグ用海上コード 



                Console.WriteLine(x_natural+"."+ x_double);
                Console.WriteLine(y_natural+"."+ y_double);

                string apiUrl = $"https://map.yahooapis.jp/geoapi/V1/reverseGeoCoder?output=json&lat={x_natural}.{x_double}&lon={y_natural}.{y_double}&appid=dj00aiZpPTFXSWpmaHFZZ0YxSSZzPWNvbnN1bWVyc2VjcmV0Jng9ZTI-";

                // APIからのレスポンスを取得
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                string decoderjson = await response.Content.ReadAsStringAsync();

                JObject decoderData = JObject.Parse(decoderjson);
                // 海か判定

                if (decoderjson.Contains("\"Address\":\"\"") == true)
                {
                    Console.WriteLine("海です!!!!");
                }
                else
                {
                    isSearch = false;   
                    // 取得したデータをコンソールに表示
                    Console.Write(decoderData["Feature"][0]["Property"]["AddressElement"][0]["Name"] + " ");
                    Console.Write(decoderData["Feature"][0]["Property"]["AddressElement"][1]["Name"] + " ");
                    Console.Write(decoderData["Feature"][0]["Property"]["AddressElement"][2]["Name"] + " ");
                    Console.Write(decoderData["Feature"][0]["Property"]["AddressElement"][3]["Name"] + " ");
                    Console.WriteLine("");
                    Console.Write(decoderData["Feature"][0]["Property"]["AddressElement"][0]["Kana"] + " ");
                    Console.Write(decoderData["Feature"][0]["Property"]["AddressElement"][1]["Kana"] + " ");
                    Console.Write(decoderData["Feature"][0]["Property"]["AddressElement"][2]["Kana"] + " ");
                    Console.Write(decoderData["Feature"][0]["Property"]["AddressElement"][3]["Kana"] + " ");
                    Console.WriteLine("");
                    Console.WriteLine("");

                }

                


            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\n例外が発生しました!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
    }
}
