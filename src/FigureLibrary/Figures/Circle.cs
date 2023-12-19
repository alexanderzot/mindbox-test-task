using FigureLibrary.Interfaces;

namespace FigureLibrary.Figures;

public class Circle: IArea
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentOutOfRangeException(nameof(radius), "Radius of circle must be greater than zero");
        _radius = radius;
    }

    public double Area()
    {
        return Math.PI * _radius * _radius;
    }
}