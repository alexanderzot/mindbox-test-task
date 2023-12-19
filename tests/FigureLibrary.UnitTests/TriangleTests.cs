using FigureLibrary.Figures;

namespace FigureLibrary.UnitTests;

public class TriangleTests
{
    private const double CompareDoubleEps = 1e-3;

    [Test]
    public void Constructor_ZeroSides_ThrowsException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 1, 1));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 0, 1));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 1, 0));
    }
    
    [Test]
    public void Constructor_NegativeSides_ThrowsException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 1, 1));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, -1, 1));
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 1, -1));
    }
    
    [Test]
    public void Constructor_NotTriangleSides_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 2));
        Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 10));
    }
    

    [Test]
    public void Area_AllSidesEqualOne_ReturnsExpectedArea()
    {
        // Arrange
        var triangle = new Triangle(1, 1, 1);
        const double expected = 0.4330;

        // Act
        var actual = triangle.Area();
        
        // Assert
        Assert.That(actual, Is.EqualTo(expected).Within(CompareDoubleEps));
    }
    
    [Test]
    public void Area_PythagoreanTriple_ReturnsExpectedArea()
    {
        // Arrange
        var triangle = new Triangle(5, 4, 3);
        const double expected = 6.0000;

        // Act
        var actual = triangle.Area();
        
        // Assert
        Assert.That(actual, Is.EqualTo(expected).Within(CompareDoubleEps));
    }
    
    [Test]
    public void IsRight_AllSidesEqualOne_NotRightTriangle()
    {
        // Arrange
        var triangle = new Triangle(1, 1, 1);
        const bool expected = false;

        // Act
        var actual = triangle.IsRight();
        
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
    
    [Test]
    public void IsRight_PythagoreanTriple_RightTriangle()
    {
        // Arrange
        var triangle = new Triangle(5, 4, 3);
        const bool expected = true;

        // Act
        var actual = triangle.IsRight();
        
        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}