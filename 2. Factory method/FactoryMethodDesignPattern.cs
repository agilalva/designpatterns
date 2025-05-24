namespace DesignPatterns._2._Factory_method;

public class FactoryMethodDesignPattern
{
    public static void Run()
    {
        DocumentCreator creator;

        creator = new WordDocumentCreator();
        var word = creator.CreateDocument();
        word.Open();

        creator = new PdfDocumentCreator();
        var pdf = creator.CreateDocument();
        pdf.Open();
    }

    /// <summary>
    /// Runs another example of Factory method.
    /// </summary>
    /// <remarks>
    /// Despite its name, product creation is not the primary responsibility of the creator.
    /// Usually, the creator class already has some core business logic related to products.
    /// The factory method helps to decouple this logic from the concrete product classes.
    /// </remarks>
    public static void Run2()
    {
        DocumentCreator creator;

        creator = new WordDocumentCreator();
        creator.EditDocument();

        creator = new PdfDocumentCreator();
        creator.EditDocument();
    }
}