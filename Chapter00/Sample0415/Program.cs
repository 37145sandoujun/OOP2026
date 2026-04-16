namespace Sample0415
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            int[] ints = new int[10];
            //入力
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write("array[" + i + "]=");
                ints[i] = int.Parse(Console.ReadLine());
            }
            //出力
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write("ints[" + i + "]=" );
                astOut(ints[i]);
                
                Console.WriteLine();
            }
            //合計
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    ints[i] += sum;
               
           // }
            Console.WriteLine(ints.Where(n=>n % 2==0).Sum());
        }
        static void astOut(int num)
        {
            for (int j = 0; j < num; j++)
            {
                Console.Write("*");
            }
        }
}
}
