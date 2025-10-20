class Word
{
    // attributes
    private string _word;
    private bool _revealed;

    // behaviors
    public Word(string w)  // constructor
    {
        _word = w;
        _revealed = true;
    }
    public void Display()
    {
        if (_revealed)
        {
            Console.Write(" " + _word);
        }
        else
        {
            Console.Write(" ___");
        }
    }
    public void Hide()  // setter
    {
        _revealed = false;
    }
    public bool IsRevealed()  // getter
    {
        return _revealed;
    }
}