namespace DesignPatterns._3._Abstract_factory;

public class WinButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering WinButton");
    }
}