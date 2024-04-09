namespace Final;

public class Word
{
    public bool IsHidden { get; set; }
    private int wordLength;
    private string word;

    public Word(string word)
    {
        foreach (var character in word)
        {
            wordLength++;
        }

        this.word = word;
    }

    public void Display()
    {
        if (IsHidden)
        {
            Console.Write(" ");
            for (int i = 0; i < wordLength; i++)
            {
                Console.Write("_");
            }
        }
        else
        {
            Console.Write(" ");
            Console.Write(word);
        }
    }
}