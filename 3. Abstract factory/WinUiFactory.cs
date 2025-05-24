namespace DesignPatterns._3._Abstract_factory;

public class WinUiFactory : IUiFactory
{
    public IButton CreateButton()
    {
        return new WinButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new WinCheckbox();
    }
}