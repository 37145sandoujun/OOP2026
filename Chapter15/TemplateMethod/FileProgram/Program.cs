using System.Text.RegularExpressions;
using System.Threading.Channels;
using TextFileProcessor;

string path = @"C:\Users\infosys\source\repos\OOP2026\Chapter14\Section04\Program.cs";

TextProcessor.Run<LineCouterProcessor>(path);

public class LineCouterProcessor : TextProcessor
{
    private int _count = 0;
    private string _serchWord = "";
    protected override void Initialize(string fname)
    {
        _count = 0;
        Console.WriteLine("カウントしたい単語：");
        _serchWord = Console.ReadLine();
    }

    protected override void Execute(string line)
    {
        _count += line.Split(_serchWord).Length - 1;
    }

    protected override void Terminate()
    {
        Console.WriteLine("{0}個", _count);
    }
}