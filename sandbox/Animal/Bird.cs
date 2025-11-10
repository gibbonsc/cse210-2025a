class Bird : Animal
{
    public Bird(string name) : base(name)
    {
        _sound = "Caw!";
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{GetName()} says {_sound}");
    }
}