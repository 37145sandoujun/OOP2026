namespace Exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintInchMeterList(1, 10);
        }
         private static void PrintInchMeterList(int start, int end){

        }

        private static void PrintMeterToFeetList(int start, int stop)
        {
            FeetConverter comverter = new FeetConverter();
            for (int meter = start; meter <= stop; meter++)
            {
                double feet = FeetConverter.ToFeet(meter);
                Console.WriteLine($"{meter}m={feet:0.0000}ft");
            }

        }
    }
}
