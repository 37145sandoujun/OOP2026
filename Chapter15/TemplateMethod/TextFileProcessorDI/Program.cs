using System.Threading.Channels;
using TextFileProcessorDI;


var service = new LineCouterService();
var processor = new TextFileProcessor(service);
Console.WriteLine("パスの入力");
processor.Run(Console.ReadLine());