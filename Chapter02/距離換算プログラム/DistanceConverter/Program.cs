namespace DistanceConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (args.Length >= 1 && args[0] == "-tom")
            {
                //フィートからメートルへの対応表を出力
                for (int feet = 0; feet <= 10; feet++)
                {
                    double meter = FeetToMeter(feet);
                    Console.WriteLine($"{feet}ft={meter:0.0000}m");

                }
            }
            else 
            {
                for (int meter = 0; meter <= 10; meter++)
                {
                    double feet = MeterToFeet(meter);
                    Console.WriteLine($"{meter}ft={feet:0.0000}m");
                }

            }
        }
        static double FeetToMeter(int feet)//フィートからメートルを求める
        { 
            //feet*0.3048
            return feet * 0.3048;
        }
        //メートルからフィートを求める
        static double MeterToFeet(int meter)
        {
            //feet*0.3048
            return meter/ 0.3048;
        }


    }
}
