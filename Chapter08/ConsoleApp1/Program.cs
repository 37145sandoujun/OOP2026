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
                if (prefCaptalLocation == null) break;


                prefOfficeDict.Add(pref, prefCaptalLocation);
            }
            //メニュー表示
            private static void manue()//メニュー表示
        {
            Console.WriteLine("****menue****");
            Console.WriteLine("1,一覧表示");
            Console.WriteLine("2,検索");
            Console.WriteLine("9,終了");
            int num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                allDisp();
            } else if (num == 2)
            {
                serchPrefCaptalLocation();
            } if (num == 9) break;

        
        }

           


private static void allDisp()
        {
            Console.WriteLine("一覧表示");
            foreach (var item in prefOfficeDict)
            {
                if (item.Key == Console.ReadLine())
                {
                    Console.WriteLine($"{item.Key}県は{item.Value}");
                }
            }
        }
        private static void serchPrefCaptalLocation()//検索表示
        {
            Console.WriteLine("都道府県");
            String? serchPref = Console.ReadLine();
        }
    }
}




