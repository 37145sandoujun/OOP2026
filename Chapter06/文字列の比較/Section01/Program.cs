using System.Globalization;

namespace Section01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var str1 = "Windows";
            var str2 = "WINDOWS";

            var cultureInfo = new CultureInfo("Ja-ap");
            if (String.Compare(str1, str2, cultureInfo,
                CompareOptions.IgnoreWidth|CompareOptions.IgnoreCase) ==0){
                Console.WriteLine("等しい");
            }
            else
            {
                Console.WriteLine("等しくない");
            }
        }
    }
}
