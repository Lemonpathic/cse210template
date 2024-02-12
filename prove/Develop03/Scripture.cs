namespace Develop03;

public class Scripture

{
    private List<int> randomChoices = new List<int>();
    private List<string[]> verses = new List<string[]>();
    private List<Word> words = new List<Word>();

    public Scripture(string[] verses)
    {
        for(int v = 0; v < verses.Length; v++)
        {
            var verseSplit = verses[v].Split(" ");
            this.verses.Add(verseSplit);
            
            for (var i = 0; i < verseSplit.Length; i++)
            {
                var splitWord = new Word(verseSplit[i], i, v);
                words.Add(splitWord);
            }
            
        }
    }

    private int GenerateRandom()
    {
        int randomNumber;
        var random = new Random();
        do
        { 
            randomNumber = random.Next(0, words.Count);
        } while (randomChoices.Contains(randomNumber));

        randomChoices.Add(randomNumber);
        return randomNumber;
    }

    public void ChooseRandomWord()
    {
        for (var i = 0; i < 3; i++)
        {
            var randomIndex = GenerateRandom();
            words[randomIndex].Hide();
        }
        Display();
    }
    
    public void Display()
    {
        int verse = 0;
        foreach (var word in words)
        {
            if (verse != word.GetVerse())
            {
                if (verse != 0)
                {
                    Console.WriteLine();
                }
                Console.Write($"Verse {word.GetVerse()}: ");
                verse = word.GetVerse();
            }
            
            word.Display();
            
        }

        Console.WriteLine('\n');
    }
    
    
}