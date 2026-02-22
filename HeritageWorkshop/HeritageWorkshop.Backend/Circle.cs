namespace HeritageWorkshop.Backend;

public class Circle : GeometricFigure
{
    // Fields
    private double _r;

    // Constructors
    public Circle(string name, double r) : base(name)
    {
        R = r;
    }

    // Properties
    public double R
    {
        get => _r;
        set => _r = ValidateR(value);
    }

    // Methods
    public override double GetArea() => Math.PI * R * R;

    public override double GetPerimeter() => 2 * Math.PI * R;

    private double ValidateR(double value)
    {
        if (value <= 0)
            throw new ArgumentOutOfRangeException(nameof(R), "R must be greater than 0");
        return value;
    }
}
