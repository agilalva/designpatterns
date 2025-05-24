namespace DesignPatterns._2._Factory_method;

public class PdfDocumentCreator : DocumentCreator
{
    public override IDocument CreateDocument()
    {
        return new PdfDocument();
    }
}