namespace ShapeLibrary.Tests;

public class TriangleTests
{
    [Test]
    public void Triangle_CreationFails_WhenSideAIsNegative()
    {
        // Arrange
        var act = () =>
        {
            _ = new Triangle(-2, 3, 4);
        };
    
        // Act & Assert
        act.Should().Throw<ArgumentException>();
    }
    
    [Test]
    public void Triangle_CreationFails_WhenSidesDoNotFormTriangle()
    {
        // Arrange
        var act = () =>
        {
            _ = new Triangle(1, 2, 10);
        };
    
        // Act & Assert
        act.Should().Throw<ArgumentException>();
    }
    
    [Test]
    public void Triangle_Area_ReturnsCorrectValue()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);
        
        // Act
        var area = triangle.Area;
        
        // Assert
        area.Should().Be(6);
    }
    
    [Test]
    public void Triangle_IsRightTriangle_ReturnsTrueForRightTriangle()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);
        
        // Act & Assert
        triangle.IsRightTriangle.Should().BeTrue();
    }
    
    [Test]
    public void Triangle_IsRightTriangle_ReturnsFalseForNonRightTriangle()
    {
        // Arrange
        var triangle = new Triangle(2, 3, 4);
        
        // Act & Assert
        triangle.IsRightTriangle.Should().BeFalse();
    }
}
