using FigureLibrary.Interfaces;

namespace FigureLibrary.Figures;

public class Triangle: IArea
{
    private readonly double _smallSide;
    private readonly double _mediumSide;
    private readonly double _bigSide;

    public Triangle(double a, double b, double c, double eps = 1e-5)
    {
        if (a <= 0)
            throw new ArgumentOutOfRangeException(nameof(a), "Side of triangle must be greater than zero");
        if (b <= 0)
            throw new ArgumentOutOfRangeException(nameof(b), "Side of triangle must be greater than zero");
        if (c <= 0)
            throw new ArgumentOutOfRangeException(nameof(c), "Side of triangle must be greater than zero");
        if (eps <= 0)
            throw new ArgumentOutOfRangeException(nameof(eps), "eps must be greater than zero");
        
        double[] sides = {a, b, c};
        Array.Sort(sides);
        if (sides[0] + sides[1] <= sides[2] + eps)
            throw new ArgumentException("Triangle with current sides does not exist");
        
        _smallSide = sides[0];
        _mediumSide = sides[1];
        _bigSide = sides[2];
    }

    public double Area()
    {
        var p = (_smallSide + _mediumSide + _bigSide) / 2f;
        var area = Math.Sqrt(p * (p - _smallSide) * (p - _mediumSide) * (p - _bigSide));
        return area;
    }

    public bool IsRight(double eps = 1e-5)
    {
        if (eps <= 0)
            throw new ArgumentOutOfRangeException(nameof(eps), "eps must be greater than zero");
        
        var delta = _smallSide * _smallSide + _mediumSide * _mediumSide - _bigSide * _bigSide;
        return Math.Abs(delta) <= eps;
    }
}