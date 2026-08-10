using System.Drawing;

public class Square : Shape
{

    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
    private double _side = 0;

    public override double GetArea()
    {
        return _side * 2;
    }
}