using System.ComponentModel.DataAnnotations;

class Entry
{
    // attributes
    public string _givenPrompt;
    public string _entryDateTime;
    public string _entryText;

    // behavior
    public void Display()
    {
        Console.Write($"{_entryDateTime} -- ");
        Console.WriteLine($"{_givenPrompt}");
        Console.WriteLine($"{_entryText}");
    }
}