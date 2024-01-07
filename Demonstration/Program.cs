using ShapeLibrary;

try
{
    IShape circle = ShapeFactory.CreateShape("circle", 5);
    Console.WriteLine($"Circle area: {circle.Area}");

    IShape triangle = ShapeFactory.CreateShape(ShapeType.Triangle, 3, 4, 5);
    Console.WriteLine($"Triangle area: {triangle.Area}");
    Console.WriteLine($"Is right triangle: {((Triangle)triangle).IsRightTriangle}");
    
    IShape wrongCircle = ShapeFactory.CreateShape("circle123", 5);
    Console.WriteLine($"Wrong circle area: {wrongCircle.Area}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}