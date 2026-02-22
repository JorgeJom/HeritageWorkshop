namespace HeritageWorkshop.Backend;

public abstract class GeometricFigure
{
    // Properties
    public string Name
    { 
        get; 
        set;
    }

    // Constructors
    protected GeometricFigure(string name)
    {
        Name = name;
    }

    // Methods
    public abstract double GetArea();
    public abstract double GetPerimeter();

    public override string ToString() =>
        $"{Name,-15} => Area......: {GetArea(),10:N5}    Perimeter: {GetPerimeter(),10:N5}";
}
