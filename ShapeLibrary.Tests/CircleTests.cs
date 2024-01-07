namespace ShapeLibrary.Tests;

public class CircleTests
{
    private const double CorrectRadius = 5;
    private const double IncorrectRadius = -5;
    
    [Test]
    public void Circle_CreatedSuccessfully()
    {
        // Act
        var circle = new Circle(CorrectRadius);
    
        // Assert
        circle.Should().NotBeNull();
    }
    
    [Test]
    public void Circle_CreationFails_WhenRadiusIsNegative()
    {
        // Arrange
        var act = () =>
        {
            _ = new Circle(IncorrectRadius);
        };
        
        // Act & Assert
        act.Should().Throw<ArgumentException>();
    }

    [Test]
    public void Circle_Area_ReturnsCorrectValue()
    {
        // Arrange
        var circle = new Circle(CorrectRadius);
        
        // Act
        var area = circle.Area;
        
        // Assert
        area.Should().Be(Math.PI * Math.Pow(CorrectRadius, 2));
    }
}
