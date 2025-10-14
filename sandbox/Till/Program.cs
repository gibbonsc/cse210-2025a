namespace Till;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        Till myTill = new Till();
        Console.WriteLine("Initial Till state:");
        myTill.Display();

        Console.Write("\nSimulate transaction:");
        Console.Write(" due $12.21, pay with $20 bill,");
        myTill.TransactBin(8, +1); // collect $20
        myTill.TransactBin(0, -4); // disburse change: 4 cents
        myTill.TransactBin(3, -3); // and three quarter
        myTill.TransactBin(5, -2); // and two dollars
        myTill.TransactBin(6, -1); // and five dollars totals $7.79 change.
        Console.WriteLine(" disbursed 7.79 in change.\n");
        Console.WriteLine("Updated Till state:");
        myTill.Display();
    }
}
