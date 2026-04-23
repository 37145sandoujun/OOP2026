using System.ComponentModel.Design;
using System.Diagnostics.Metrics;

namespace DistanceConverter
{
    internal class Program
    {
        public static object PrintMeterToFeet { get; private set; }

        static void Main(string[] args)
        {
            if (args.Length == 3
                && int.TryParse(args[1], out int start) && int.TryParse(args[2], out int end)){
                if (args[0] == "tom")
                {
                    PrintFeetToMeterList(start, end);

                }
                else if (args[0] == "-tof")
                {
                    PrintMeterToFeetList(start, end);//メートルからフィートへの変換
                }
                else
                {
                    Console.WriteLine("引数形式エラー");
                    

                }
            }
            else { Console.WriteLine("引数エラー"); }
        }




        private static void PrintMeterToFeetList(int start, int stop)
        {
            FeetConverter comverter=new FeetConverter();
            for (int meter = start; meter <= stop; meter++)
            {
                double feet =FeetConverter.ToFeet(meter);
                Console.WriteLine($"{meter}m={feet:0.0000}ft");
            }

        }

        private static void PrintFeetToMeterList(int start, int stop)
        {
            FeetConverter comverter = new FeetConverter();
            for (int feet = start; feet <= stop; feet++)
            {
                double meter =FeetConverter.FromMeter(feet);
                Console.WriteLine($"{feet}ft={meter:0.0000}m");

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
            return meter / 0.3048;
        }


    }
}
