
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Animal World!");
        Mammal myPet = new Mammal("Ali");
        Console.WriteLine($"{myPet}");
        myPet.MakeNoise();
        Mammal myLagomorph = new Rabbit("Shadow");
        Console.WriteLine($"{myLagomorph}");
        myLagomorph.MakeNoise();
        Mammal myFeline = new Tiger("Hobbes");
        Console.WriteLine($"{myFeline}");
        myFeline.MakeNoise();
        Mammal myFox = new Fox("Ylvis");
        Console.WriteLine($"{myFox}");
        myFox.MakeNoise();
    }
}
