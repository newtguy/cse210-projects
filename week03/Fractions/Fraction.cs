public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        this._top = 1;
        this._bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        this._top = wholeNumber;
        this._bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        this._top = top;
        this._bottom = bottom;
    }

    private int GetTop()
    {
        return this._top;
    }

    public void SetTop(int top)
    {
        this._top = top;
    }

    private int GetBottom()
    {
        return this._bottom;
    }

    public void SetBottom(int bottom)
    {
        this._bottom = bottom;
    }

    public string GetFractionString()
    {
        return GetTop() + "/" + GetBottom();
    }

    public double GetDecimalValue()
    {
        return (double)GetTop() / GetBottom();
    }
}