public class Circle : Shape
{
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }
    private double _radius = 0;

    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}