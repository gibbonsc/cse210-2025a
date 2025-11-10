class Animal
{
    private string _name;
    protected string _sound="";

    public Animal(string species)
    {
        _name = species;
    }
    public string GetName()
    {
        return _name;
    }
    
    public virtual void MakeSound()
    {
        Console.WriteLine($"{GetName()} makes a noise.");
    }
}