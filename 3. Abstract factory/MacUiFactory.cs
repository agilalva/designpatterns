namespace DesignPatterns._3._Abstract_factory;

public class MacUiFactory : IUiFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new MacCheckbox();
    }
}