namespace HeritageWorkshop.Backend;

public class Square : GeometricFigure
{
    // Fields
    private double _a;

    // Constructors
    public Square(string name, double a) : base(name)
    {
        A = a;
    }

    // Properties
    public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }

    // Methods
    public override double GetArea() => A * A;

    public override double GetPerimeter() => 4 * A;

    private double ValidateA(double value)
    {
        if (value <= 0)
            throw new ArgumentOutOfRangeException(nameof(A), "A must be greater than 0");
        return value;
    }
}