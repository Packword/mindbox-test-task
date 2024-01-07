namespace ShapeLibrary.Tests;
public class ShapeFactoryTests
{
    [TestCaseSource(nameof(CreateCorrectShapesData))]
    public void ShapeFactory_CreateShapeWithEnumType_ReturnsCorrectType(ShapeType type, Type correctType, double[] args)
    {
        // Act
        var shape = ShapeFactory.CreateShape(type, args);
        
        // Assert
        shape.Should().NotBeNull();
        shape.Should().BeOfType(correctType);
    }
    
    [TestCaseSource(nameof(CreateCorrectShapesStringData))]
    public void ShapeFactory_CreateShapeWithStringType_ReturnsCorrectType(string type, Type correctType, double[] args)
    {
        // Act
        var shape = ShapeFactory.CreateShape(type, args);
        
        // Assert
        shape.Should().NotBeNull();
        shape.Should().BeOfType(correctType);
    }
    
    [TestCaseSource(nameof(CreateIncorrectShapesData))]
    public void ShapeFactory_CreateShapeWithEnumType_ThrowArgumentException(ShapeType type, double[] args, string message)
    {
        // Arrange
        var act = () => ShapeFactory.CreateShape(type, args);
        
        // Act & Assert
        act.Should().Throw<ArgumentException>().WithMessage(message);
    }

    private static IEnumerable<TestCaseData> CreateCorrectShapesData()
    {
        yield return new TestCaseData(ShapeType.Circle, typeof(Circle), new double[] { 5 });
        yield return new TestCaseData(ShapeType.Triangle, typeof(Triangle), new double[] { 3, 4, 5 });
    }
    
    private static IEnumerable<TestCaseData> CreateIncorrectShapesData()
    {
        yield return new TestCaseData((ShapeType)99, new double[] { 5 }, "Invalid shape type (Parameter 'type')");
        yield return new TestCaseData(ShapeType.Circle, Array.Empty<double>(), "Circle should have one parameter: radius.");
        yield return new TestCaseData(ShapeType.Triangle, new double[] {1, 2}, "Triangle should have three parameters: side1, side2, side3.");
    }
    
    private static IEnumerable<TestCaseData> CreateCorrectShapesStringData()
    {
        yield return new TestCaseData("circle", typeof(Circle), new double[] { 5 });
        yield return new TestCaseData("Circle", typeof(Circle), new double[] { 5 });
        yield return new TestCaseData("triangle", typeof(Triangle), new double[] { 3, 4, 5 });
    }
}
