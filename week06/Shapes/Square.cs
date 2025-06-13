public class Square : Shape
{
    private double _lengthSide;

    public Square(string color, double lengthSide) : base(color)
    {
        this._lengthSide = lengthSide;
    }

    public override double GetArea()
    {
        return this._lengthSide * this._lengthSide;
    }
}