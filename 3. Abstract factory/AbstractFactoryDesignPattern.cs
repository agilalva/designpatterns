namespace DesignPatterns._3._Abstract_factory;

public static class AbstractFactoryDesignPattern
{
    public static void Run()
    {
        //IUiFactory factory = new WinUiFactory();
        IUiFactory factory = new MacUiFactory();

        var app = new Application(factory);
        app.Render();
    }

    private class Application(IUiFactory factory)
    {
        private readonly IButton _button = factory.CreateButton();
        private readonly ICheckbox _checkbox = factory.CreateCheckbox();

        public void Render()
        {
            _button.Render();
            _checkbox.Render();
        }
    }
}