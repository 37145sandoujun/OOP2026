using System.Diagnostics;

namespace Section01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4 };
            
            var books = Books.GetBooks();
            var priceAverage= books.Average(x=>x.Price);
            var pageAverage= books.Sum(x => x.Price);
            var maxPrice = books.Max(x => x.Price);

            Console.WriteLine("平均金額:" + priceAverage);
            Console.WriteLine("合計ページページ:" + pageAverage);
            Console.WriteLine("高価な本:" + maxPrice);
           

            Console.WriteLine("ーーーー500円以上の本ーーーー" );
            foreach(var book in books.Where(x => x.Price >= 500))
            {
                Console.WriteLine(book.Title);
            }
            //本のページが２５０ページ以上の本を上位三冊出力
            Console.WriteLine("ーーーー２５０ページ以上の本を上位三冊ーーーー");
            foreach (var book in books.Where(x => x.Price >= 250).Take(3))
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
