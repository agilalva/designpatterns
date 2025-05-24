namespace DesignPatterns._2._Factory_method;

public class WordDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening word document");
    }

    public void Close()
    {
        Console.WriteLine("Closing word document");
    }
}