namespace Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            // 3.1.1
            Exercise1(numbers);
            Console.WriteLine("-----");

            // 3.1.2
            Exercise2(numbers);
            Console.WriteLine("-----");

            // 3.1.3
            Exercise3(numbers);
            Console.WriteLine("-----");

            //3.1.4
            Exercise4(numbers);
        }

        private static void Exercise1(List<int> numbers)
        {
            var exists = numbers.Exists(t => t % 8 ==0|| t % 9 == 0);
            if(exists == true){
                Console.WriteLine("存在する");
            }
        }
        private static void Exercise2(List<int> numbers)
        {
            foreach(var n in numbers)
            {
                Console.WriteLine(n/2.0);
            }
        }
        private static void Exercise3(List<int> numbers)
        {
            var query = numbers.Where(t => t >=50);
            foreach(var item in query)
            {
                Console.WriteLine(item);
            }
        }
        private static void Exercise4(List<int> numbers)
        {
            var select = numbers.Select(t => t * 2);
            foreach(var item in select)
            {
                Console.WriteLine(item);
            }
        }

    }
}
