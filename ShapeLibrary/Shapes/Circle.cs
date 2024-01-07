namespace ShapeLibrary;

public readonly struct Circle: IShape
{
    /// <inheritdoc />
    public double Area => Math.PI * Math.Pow(_radius, 2);
    
    private readonly double _radius;

    /// <summary>
    /// Creates a new instance of the Circle struct
    /// </summary>
    /// <param name="radius">Radius of the circle</param>
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius should be greater than 0.");
        
        _radius = radius;
    }
}
