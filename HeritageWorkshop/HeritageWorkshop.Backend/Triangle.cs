namespace HeritageWorkshop.Backend;

public class Triangle : Rectangle
{
    // Fields
    private double _c;
    private double _h;

    // Constructors
    public Triangle(string name, double a, double b, double c, double h)
        : base(name, a, b)
    {
        C = c;
        H = h;
    }

    // Properties
    public double C
    {
        get => _c;
        set => _c = ValidateC(value);
    }

    public double H
    {
        get => _h;
        set => _h = ValidateH(value);
    }

    // Methods
    public override double GetArea() => (B * H) / 2;

    public override double GetPerimeter() => A + B + C;

    private double ValidateC(double value)
    {
        if (value <= 0)
            throw new ArgumentOutOfRangeException(nameof(C), "C must be greater than 0");
        return value;
    }

    private double ValidateH(double value)
    {
        if (value <= 0)
            throw new ArgumentOutOfRangeException(nameof(H), "H must be greater than 0");
        return value;
    }
}
