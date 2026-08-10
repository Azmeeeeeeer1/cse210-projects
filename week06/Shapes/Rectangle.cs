public class Rectangle : Shape
{
    public Rectangle(string color, double lenght, double width) : base(color)
    {
        _lenght = lenght;
        _width = width;
    }
    private double _lenght = 0;
    private double _width = 0;

    public override double GetArea()
    {
        return _lenght * _width;
    }
}