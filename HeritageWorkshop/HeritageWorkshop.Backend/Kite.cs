namespace HeritageWorkshop.Backend;

public class Kite : Rhombus
{
    // Fields
    private double _b;

    // Constructors
    public Kite(string name, double a, double b, double d1, double d2)
        : base(name, a, d1, d2)
    {
        B = b;
    }

    // Properties
    public double B
    {
        get => _b;
        set => _b = ValidateB(value);
    }

    // Methods
    public override double GetArea() => (D1 * D2) / 2;

    public override double GetPerimeter() => 2 * (A + B);

    private double ValidateB(double value)
    {
        if (value <= 0)
            throw new ArgumentOutOfRangeException(nameof(B), "B must be greater than 0");
        return value;
    }
}
