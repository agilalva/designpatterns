namespace DesignPatterns._3._Abstract_factory;

public class MacButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering MacButton");
    }
}