namespace Sample0413
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("表示回数:");
            string imputNum = Console.ReadLine();//入力

            int count = int.Parse(imputNum);//整数への変換
            int i = 0;
            while (count > i)
            {
                    Console.Write(i + 1 + ":");
                    Console.WriteLine(":Hello");//画面出力
                i++;
            }

        }
    }
}
