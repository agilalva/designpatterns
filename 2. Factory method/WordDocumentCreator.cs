namespace DesignPatterns._2._Factory_method;

public class WordDocumentCreator : DocumentCreator
{
    public override IDocument CreateDocument()
    {
        return new WordDocument();
    }
}