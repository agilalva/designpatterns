namespace DesignPatterns._2._Factory_method;

public class PdfDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Opening pdf document");
    }

    public void Close()
    {
        Console.WriteLine("Closing pdf document");
    }
}