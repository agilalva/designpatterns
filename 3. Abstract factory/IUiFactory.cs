namespace DesignPatterns._3._Abstract_factory;

public interface IUiFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}