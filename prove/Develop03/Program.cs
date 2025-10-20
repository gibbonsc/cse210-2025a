using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        Word word1 = new Word("Now");
        Word word2 = new Word("behold.");
        word1.Display();
        word2.Display();
        word1.Hide();
        word1.Display();
        word2.Display();
    }
}