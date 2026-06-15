using System.Linq;
using System.Text;

namespace Section05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sb = new[] { "Orange", "Lemon", "Strawberry" };
            var sep = ',';
            

                var result = String.Join(",", GetWords());
            Console.WriteLine(result);
               
            
            
            
        }
        private static IEnumerable<object>GetWords()
        {
            return ["Orange", "Lemon", "Strawberry"];
        }
    }
}
