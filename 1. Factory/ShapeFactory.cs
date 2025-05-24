namespace DesignPatterns.Factory;

public static class ShapeFactory
{
    public static IShape GetShape(string type)
    {
        return type switch
        {
            "circle" => new Circle(),
            "rectangle" => new Rectangle(),
            _ => throw new ArgumentException("Invalid type")
        };
    }
}