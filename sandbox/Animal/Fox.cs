class Fox : Animal
{
    public Fox(string name) : base(name)
    {
        _sound = "Ring-ding-ding-ding-dingeringeding!";
    }
    public override void MakeSound()
    {
        Console.WriteLine($"A {this.GetType()} named {GetName()} sings {_sound}");
    }
}
