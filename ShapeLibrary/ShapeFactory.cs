namespace ShapeLibrary;

/// <summary>
/// Factory for creating shapes
/// </summary>
public static class ShapeFactory
{
    private const string InvalidShapeMessage = "Invalid shape type";
    private const string CircleTypeName = "circle";
    private const string TriangleTypeName = "triangle";
    
    /// <summary>
    /// Creates a new shape
    /// </summary>
    /// <param name="type">Type of shape</param>
    /// <param name="args">Arguments for creating the shape</param>
    /// <returns>A new shape</returns>
    public static IShape CreateShape(ShapeType type, params double[] args)
    { 
        return type switch
        {
            ShapeType.Circle => CreateCircle(args),
            ShapeType.Triangle => CreateTriangle(args),
            _ => throw new ArgumentException(InvalidShapeMessage, nameof(type))
        };
    }
    
    /// <summary>
    /// Creates a new shape
    /// </summary>
    /// <param name="type">Type of shape</param>
    /// <param name="args">Arguments for creating the shape</param>
    /// <returns>A new shape</returns>
    public static IShape CreateShape(string type, params double[] args)
    {
        return type.ToLower() switch
        {
            CircleTypeName => CreateCircle(args),
            TriangleTypeName => CreateTriangle(args),
            _ => throw new ArgumentException(InvalidShapeMessage, type)
        };
    }

    private static IShape CreateTriangle(IReadOnlyList<double> args)
    {
        if (args.Count != 3)
            throw new ArgumentException("Triangle should have three parameters: side1, side2, side3.");
        return new Triangle(args[0], args[1], args[2]);
    }

    private static IShape CreateCircle(IReadOnlyList<double> args)
    {
        if (args.Count != 1)
            throw new ArgumentException("Circle should have one parameter: radius.");
        return new Circle(args[0]);
    }
}