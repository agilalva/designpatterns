namespace DesignPatterns._3._Abstract_factory;

public class WinCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering WinCheckbox");
    }
}