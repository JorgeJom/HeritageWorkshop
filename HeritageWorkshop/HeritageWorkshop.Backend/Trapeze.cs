namespace HeritageWorkshop.Backend;

public class Trapeze : Triangle
{
    // Fields
    private double _d;

    // Constructors
    public Trapeze(string name, double a, double b, double c, double d, double h)
        : base(name, a, b, c, h)
    {
        D = d;
    }

    // Properties
    public double D
    {
        get => _d;
        set => _d = ValidateD(value);
    }

    // Methods
    public override double GetArea() => ((B + D) * H) / 2;

    public override double GetPerimeter() => A + B + C + D;

    private double ValidateD(double value)
    {
        if (value <= 0)
            throw new ArgumentOutOfRangeException(nameof(D), "D must be greater than 0");
        return value;
    }
}
