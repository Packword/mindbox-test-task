namespace ShapeLibrary;

/// <summary>
/// Struct for a triangle
/// </summary>
public readonly struct Triangle: IShape
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;
    
    private const double Tolerance = 1e-10;
    
    /// <inheritdoc />
    public double Area
    {
        get
        {
            var p = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }
    }
    
    /// <summary>
    /// Checks if the triangle is a right triangle
    /// </summary>
    public bool IsRightTriangle =>
        Math.Abs(Math.Pow(_sideA, 2) + Math.Pow(_sideB, 2) - Math.Pow(_sideC, 2)) < Tolerance ||
        Math.Abs(Math.Pow(_sideB, 2) + Math.Pow(_sideC, 2) - Math.Pow(_sideA, 2)) < Tolerance ||
        Math.Abs(Math.Pow(_sideA, 2) + Math.Pow(_sideC, 2) - Math.Pow(_sideB, 2)) < Tolerance;
    
    /// <summary>
    /// Creates a new instance of the Triangle struct
    /// </summary>
    /// <param name="sideA">Length of the first side of the triangle</param>
    /// <param name="sideB">Length of the second side of the triangle</param>
    /// <param name="sideC">Length of the third side of the triangle</param>
    public Triangle(double sideA, double sideB, double sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
        
        if (!IsValid())
        {
            throw new ArgumentException("Invalid triangle sides");
        }
    }
    
    private bool IsValid()
    {
        return _sideA > 0 && _sideB > 0 && _sideC > 0 && _sideA + _sideB > _sideC && _sideA + _sideC > _sideB &&
               _sideB + _sideC > _sideA;
    }
}