using TextFileProcessor;


string path = @"C:\Users\infosys\source\repos\OOP2026\Chapter14\演習問題\Exercise01_WPF\走れメロス.txt";
TextProcessor.Run<LineCouterProcessor>(path);

public class LineCouterProcessor:TextProcessor
{
    private int _count = 0;

    protected override void Initialize(string fname) =>
    
        _count = 0;

    protected override void Execute(string line)=>
    
        _count++;

    protected override void Terminate()=>
    
        Console.WriteLine("{0}行",_count);
    
}