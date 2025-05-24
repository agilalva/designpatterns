namespace DesignPatterns._2._Factory_method;

public abstract class DocumentCreator
{
    public abstract IDocument CreateDocument();

    public void EditDocument()
    {
        var doc = CreateDocument();
        doc.Open();
        Console.WriteLine("Editing document");
        doc.Close();
    }
}