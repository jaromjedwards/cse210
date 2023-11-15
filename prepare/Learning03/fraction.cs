class Fraction
{
    private int _topNumber;
    private int _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(int top)
    {
        _topNumber = top;
        _bottomNumber = 1;
    }

        public Fraction(int top, int bottom)
    {
        _topNumber = top;
        _bottomNumber = bottom;
    }

    public (int, int) GetNumbers()
    {
        return (_topNumber, _bottomNumber);
    }
    public void SetNumbers(int topNumber, int bottomNumber)
    {
        _topNumber = topNumber;
        _bottomNumber = bottomNumber;
    }

    public string GetFractionalView()
    {
        return $"{_topNumber}/{_bottomNumber}";
    }

    public double GetDecimalView()
    {
        return (double) _topNumber/_bottomNumber;
    }
}