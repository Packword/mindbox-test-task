namespace ShapeLibrary;

/// <summary>
/// Interface for a shape
/// </summary>
public interface IShape
{
    /// <summary>
    /// Calculates the area of the shape
    /// </summary>
    double Area { get; }
}