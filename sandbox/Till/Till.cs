namespace Till;
class Till
{
    // attribute
    private List<Bin> _bins;

    // behaviors...
    // constructor
    public Till()
    {
        // initialize to a standard "start of shift" cash configuration
        _bins = new List<Bin>();
        // append nine bins (one for each denomination) to the list:
        _bins.Add(new Bin("Pennies", 0.01, 50)); // a roll of penny coins
        _bins.Add(new Bin("Nickels", 0.05, 40)); // $2 in nickels
        _bins.Add(new Bin("Dimes", 0.10, 50)); // $5 in dimes
        _bins.Add(new Bin("Quarters", 0.25, 40)); // $10 in quarters
        _bins.Add(new Bin("Half-Dollars", 0.50, 0)); // empty bin
        _bins.Add(new Bin("One-dallar notes", 1.00, 25)); // standard stack of paper
        _bins.Add(new Bin("Five-dollar notes", 5.00, 6)); // $30 in five dollar bills
        _bins.Add(new Bin("Ten-dollar notes", 10.00, 2)); // $20 in ten dollar bills
        _bins.Add(new Bin("Twenty-dollar notes", 20.00, 2)); // $40 in twenty dollar bills
    }

    // modifier method
    public bool TransactBin(int index, int count)
    // if count is positive: add to a particular bin
    // if count is negative: take away from a particular bin
    {
        bool result = false; // (will return false if not enough in bin)
        Bin selectedBin = _bins[index];
        int available = _bins[index].GetCount();
        if (available + count >= 0) // make sure the bin has enough in it
        {
            _bins[index].Alter(count);
            result = true;
        }
        return result;
    }

    // getter method: calculate total cash value in the Till
    public double GetTotalValue()
    {
        double result = 0.0;
        foreach (Bin b in _bins)
        {
            result += b.GetValue() * b.GetCount();
        }
        return result;
    }

    // display method: comprehensive status of the Till
    public void Display()
    {
        foreach (Bin b in _bins)
        {
            Console.WriteLine($"{b.GetDenomination()}: {b.GetCount()}");
        }
        Console.WriteLine($"Total cash value: ${GetTotalValue():F2}");
    }
}
