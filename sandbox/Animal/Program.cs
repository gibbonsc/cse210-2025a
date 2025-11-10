class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Polymorphic World!");

        Animal a = new Animal("Beast");
        Bird bird = new Bird("Blackbird");
        Fox fox = new Fox("Ylvis");

        a.MakeSound();
        bird.MakeSound();
        fox.MakeSound();
    }
}
