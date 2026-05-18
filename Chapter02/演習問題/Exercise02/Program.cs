namespace Exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintInchMeterList(1, 10);
        }
        private static void PrintInchMeterList(int start, int end) {


        

       
        
            
            for (int feet = start; feet <= end; feet++)
            {
                double meter = InchConverter.FromMeter(feet);
                Console.WriteLine($"{feet}inch={meter:0.0000}m");
            }

        }
    }
}
