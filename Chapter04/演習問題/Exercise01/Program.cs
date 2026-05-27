namespace Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> langs = [
               "C#", "Java", "Ruby", "PHP", "Python", "TypeScript",
                "JavaScript", "Swift", "Go",
            ];

            Exercise1(langs);
            Console.WriteLine("---");
            Exercise2(langs);
            Console.WriteLine("---");
            Exercise3(langs);
            
        }
        private static void Exercise01(List<string> langs)
        {
            var s = langs.Where(s => s.Contains('S')).ToList();
            //foreach文
            Console.WriteLine("foreach文で出力");


            foreach (var lang in langs)
            {
                if (lang.Contains('S'))
                    Console.WriteLine(lang);
            }




            Console.WriteLine();//改行
            //for
            Console.WriteLine("for文で出力");


            for (int n = 0; n < langs.Count(); n++)
            {
                if (langs[n].Contains('s'))
                    Console.WriteLine(langs[n]);
            }




            Console.WriteLine();//改行
            //while
            Console.WriteLine("while文で出力");
            int count = 0;
            while (count < langs.Count)
            {
                if (langs[count].Contains('s'))

                    Console.WriteLine(langs[count]);
                count++;

            }
        }

        private static void Exercise02(List<string> langs)
        {
            Console.WriteLine("\n---4.1.2---");
            var selected = langs.Where(s => s.Contains('s'));
            foreach(var lang in selected){
                Console.WriteLine(lang);
            }

        }

        private static void Exercise03(List<string> langs)
        {
            Console.WriteLine("\n---4.1.3---");
            var lang = langs.Find(s => s.Length == 10) ?? "unknown";
            Console.WriteLine(lang);
        }




    }
}
