class Bin
{
    // attributes
    private string _denomination;
    private double _value;
    private int _count;

    // behaviors...
    // constructor
    public Bin(string d, double v, int c)
    {
        _denomination = d;
        _value = v;
        _count = c;
    }
    // modifier method "Alter"
    public void Alter(int delta)
    {
        _count += delta;
    }
    // accessor ("getter") methods
    public string GetDenomination()
    {
        return _denomination;
    }
    public double GetValue()
    {
        return _value;
    }
    public int GetCount()
    {
        return _count;
    }
}