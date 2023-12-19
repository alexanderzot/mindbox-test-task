using FigureLibrary.Figures;

namespace FigureLibrary.UnitTests;

public class CircleTests
{
    private const double CompareDoubleEps = 1e-3;

    [Test]
    public void Constructor_ZeroRadius_ThrowsException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(0));
    }
    
    [Test]
    public void Constructor_NegativeRadius_ThrowsException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
    }
    
    [Test]
    public void Area_OneRadius_ReturnsExpectedArea()
    {
        // Arrange
        var circle = new Circle(1);
        const double expected = 3.1416;

        // Act
        var actual = circle.Area();
        
        // Assert
        Assert.That(actual, Is.EqualTo(expected).Within(CompareDoubleEps));
    }
    
    [Test]
    public void Area_TwoRadius_ReturnsExpectedArea()
    {
        // Arrange
        var circle = new Circle(2);
        const double expected = 12.5664;

        // Act
        var actual = circle.Area();
        
        // Assert
        Assert.That(actual, Is.EqualTo(expected).Within(CompareDoubleEps));
    }
}