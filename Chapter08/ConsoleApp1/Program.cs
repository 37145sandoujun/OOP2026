using System;
using System.Runtime.CompilerServices;
using System.Threading.Channels;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {

        static private Dictionary<string, string> prefOfficeDict = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            string? pref, prefCaptalLocation;

            Console.WriteLine("県庁所在地の登録（入力終了：Ctrl+'z')");


            while (true)
            {
                //都道府県の入力
                Console.WriteLine("都道府県");
                pref = Console.ReadLine();
                if (pref == null) break;//無限ループを抜ける

                //県庁所在地の入力
                Console.WriteLine("県庁所在地");
                prefCaptalLocation = Console.ReadLine();

                if (prefOfficeDict.ContainsKey(pref))
                {
                    Console.WriteLine("上書きしますか?(y/n)");
                    if (Console.ReadLine() == "n") continue;
                }

                prefOfficeDict[pref] = prefCaptalLocation;
                Console.WriteLine();


            }

            Boolean endFlag = false;    //終了フラグ（メニューの無限ループを抜ける用）
            while (!endFlag)
            {
                switch (menuDisp())
                {
                    case 1: //一覧出力処理
                        allDisp();
                        break;

                    case 2:
                        searchPrefCaptalLocation();
                        break;

                    default:
                        endFlag = true;
                        break;
                }
            }
        }











        //メニュー表示
        private static void menuDisp()//メニュー表示
        {
            Console.WriteLine("\n****menue****");
            Console.WriteLine("1,一覧表示");
            Console.WriteLine("2,検索");
            Console.WriteLine("9,終了");
            Console.Write(">");

             
            
           // return int.Parse(Console.ReadLine());
        
        }




        private static void allDisp()
        {
            Console.WriteLine("一覧表示");
            foreach (var p in prefOfficeDict)
            {
                Console.WriteLine($"{p.Key}県の県庁所在地は{p.Value}");

            }
        }
        private static void searchPrefCaptalLocation()//検索表示
        {
            Console.WriteLine("都道府県");
            var serchPref = Console.ReadLine();
            if (serchPref is null) return;
            if (prefOfficeDict.ContainsKey(serchPref))
            {
                Console.WriteLine(serchPref + "の県庁所在地は" + prefOfficeDict[serchPref] + "です");
            }
        }
    }
}




