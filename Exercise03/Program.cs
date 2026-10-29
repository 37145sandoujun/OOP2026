using Exercise03;
using TextFileProcessorDI;

var service = new Take20Service();
var processor = new TextFileProcessor(service);
Console.WriteLine("パスの入力");
processor.Run(Console.ReadLine());