using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(wholeNumber int)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(top int, bottom int)
    {
        _top = top;
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        string text = $"{_top}/{bottom}";
        retrun text;
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

}