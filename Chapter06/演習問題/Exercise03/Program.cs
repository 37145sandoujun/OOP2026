
using System.Reflection.Metadata;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";
            #region
            Console.WriteLine("6.3.1");
            Exercise1(text);

            Console.WriteLine("6.3.2");
            Exercise2(text);

            Console.WriteLine("6.3.3");
            Exercise3(text);

            Console.WriteLine("6.3.4");
            Exercise4(text);

            Console.WriteLine("6.3.5");
            Exercise5(text);

            Console.WriteLine("6.3.99");
            Exercise6(text);
            #endregion
        }

        private static void Exercise1(string text) {
            var spaces = text.Count(c => c == ' ');
            Console.WriteLine($"空白数:{spaces}");
            //別の書き方
            //Console.WriteLine("空白数:{0}", spaces);
        }

        private static void Exercise2(string text) {
            Console.Write("検索：");
            var search = Console.ReadLine();
            Console.Write("置換：");
            var replace = Console.ReadLine();

            var replaced = text.Replace(search, replace);
            Console.WriteLine(replaced);
        }

        private static void Exercise3(string text) {
            //やらなくてよい
        }

        private static void Exercise4(string text) {
            var count = text.Split( ' ').Length;
            Console.WriteLine($"単語数:{count+1}");
        }

        private static void Exercise5(string text) {
            //テスト出る
             text.Split(' ').Where(s => s.Length <= 4).ToList().ForEach(Console.WriteLine); 
            
           
        }

        //アルファベットの数をカウントして表示する
        private static void Exercise6(string text) {
            //辞書を使った集計
            var str = text.ToLower().Replace("", "");
            var alphdicCount = Enumerable.Range('a', 26).
                ToDictionary(num => ((char)num), num => 0);
               // var dict = new SortedDictionary<char, int>();
            foreach(var c in str)
            {
                alphdicCount[c]++;

                foreach (var word in alphdicCount)
                {
                    Console.WriteLine(word.Key+":"+word.Value);
                }

            }
            foreach(var word in alphdicCount)
            {
                Console.WriteLine(word.Key+":"+word.Value);
            }
            
        }
    }
}
