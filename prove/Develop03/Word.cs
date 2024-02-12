namespace Develop03;

public class Word

{
    private string word;
    private int index;
    private int verse;
    private bool isHidden;
    
    public Word(string word, int index, int verse)
    {
        this.word = word;
        this.index = index;
        this.verse = verse;
    }

    public void Hide()
    {
        this.isHidden = true;
    }

    public int GetVerse()
    {
        return verse + 1;
    }
    public void Display()
    {
        if (!isHidden)
        {
            Console.Write($"{word} ");
        }
        else
        {
            foreach (var letter in word)
            {
                Console.Write('_');
            }

            Console.Write(" ");
        }
    }
}