namespace DesignPatterns.Factory;

public static class FactoryDesignPattern
{
    public static void Run()
    {
        var shape1 = ShapeFactory.GetShape("circle");
        shape1.Draw();

        var shape2 = ShapeFactory.GetShape("rectangle");
        shape2.Draw();
    }
}