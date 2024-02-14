namespace Develop03;

public class Scripture

{
    private List<int> randomChoices = new List<int>();
    private List<string[]> verses = new List<string[]>();
    private List<Word> words = new List<Word>();
    private int minVerse;



    public Scripture(List<string> verses, int minVerse)
    {
        this.minVerse = minVerse;
        Console.WriteLine(this.minVerse);
        for(int c = 0, v = minVerse; v < verses.Count + minVerse; v++, c++)
        {
            var verseSplit = verses[c].Split(" ");
            this.verses.Add(verseSplit);
            
            for (var i = 0; i < verseSplit.Length; i++)
            {
                var splitWord = new Word(verseSplit[i], i, v);
                words.Add(splitWord);
            }
            
        }
    }

    private (int,bool) GenerateRandom()
    {
        int randomNumber;
        var random = new Random();
        if (randomChoices.Count < words.Count)
        {
            do
            { 
                randomNumber = random.Next(0, words.Count);
            } while (randomChoices.Contains(randomNumber));
            randomChoices.Add(randomNumber);
            return (randomNumber,false);
        }

        Console.WriteLine("Scripture Mastered!");
        return (0,true);
    }

    public void ChooseRandomWord()
    {
        for (var i = 0; i < 3; i++)
        {
            var (randomIndex,mastered) = GenerateRandom();
            if (mastered)
            {
                return;
            }
            words[randomIndex].Hide();
        }
        Display();
    }
    
    public void Display()
    {
        int verse = minVerse;
        foreach (var word in words)
        {
            if (verse != word.GetVerse())
            {
                if (verse != minVerse)
                {
                    Console.WriteLine();
                }
                Console.Write($"Verse {word.GetVerse() - 1}: ");
                verse = word.GetVerse();
            }
            
            word.Display();
            
        }

        Console.WriteLine('\n');
    }
    
    
}