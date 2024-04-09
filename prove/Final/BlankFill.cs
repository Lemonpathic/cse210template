namespace Final;

public class BlankFill:Activity
{
    private List<CardSet> usableCardsets = new List<CardSet>();
    private string title = "----------==[Blank Space]==----------\n";
    public BlankFill(List<CardSet> cardSets):base("Blank Space",false)
    {
        UserHasLongEnoughDefs(cardSets);
        if (usableCardsets.Count == 0)
        {
            Console.WriteLine("Sorry you do not have long enough definitions for your cards.");
            isFinished = true;
        }

        while (!isFinished)
        {
            Menu();
        }
    }
    protected override void WelcomeMessage()
    {
        Console.WriteLine("Welcome to Blank Space Review, Each round a set number of words will disappear from your card\n" +
                          "Try to memorize as many as you can!");
    }

    protected override void Menu()
    {
        Console.Clear();
        Console.WriteLine($"{title}" +
                          $"{buffer}1. Choose a card set\n" +
                          $"{buffer}2. Review a random set\n" +
                          $"{buffer}3. Finish");

        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Console.Clear();
                Console.WriteLine($"{title}" +
                                  $"Choose a card set: [] = How Many Cards Available for Blank Space");
                int count = 0;
                foreach (var cardSet in usableCardsets)
                {
                    count++;
                    Console.WriteLine($"{count}. {cardSet.GetName()} [{cardSet.UsableCards}]");
                }

                int cardInput = int.Parse(Console.ReadLine()) - 1;
                RunReview(cardInput);

                break;
            case "2":
                Console.Clear();
                Random random = new Random();
                int randomInt = random.Next(0, usableCardsets.Count);
                Console.WriteLine($"{title}\n" +
                                  $"Reviewing: {usableCardsets[randomInt].GetName()}\n" +
                                  $"There are {usableCardsets[randomInt].UsableCards} you can review from this set.");
                Thread.Sleep(3000);
                RunReview(randomInt);

                break;
            case "3":
                Console.Clear();
                isFinished = true;
                break;
        }
    }

    protected override void Completed()
    {
        throw new NotImplementedException();
    }

    private void RunReview(int cardInput)
    {
        foreach (var card in usableCardsets[cardInput].GetFlashCards())
        {
            List<Word> words = new List<Word>();
            List<Word> hiddenWords = new List<Word>();
            List<int> hiddenWordIndexes = new List<int>();
            foreach (var word in card.back.Split(" "))
            {
                var wordClass = new Word(word);
                words.Add(wordClass);   
            }

            while (words.Count != hiddenWordIndexes.Count)
            {
                int randomInt = -1;
                
                
                
                do
                {
                    for (int i = 0; i < 2; i++)
                    {
                        if (words.Count == hiddenWordIndexes.Count)
                        {
                            Console.Clear();
                            foreach (var word in words)
                            {
                                word.Display();
                            }

                            Console.ReadLine();
                           break;
                        }
                        Random random = new Random();
                        randomInt = random.Next(0, words.Count); 
                        
                    }
                    


                } while (hiddenWordIndexes.Contains(randomInt));
                

                hiddenWordIndexes.Add(randomInt);
                words[randomInt].IsHidden = true;
               Console.Clear();
               Console.WriteLine(title);
               Console.WriteLine(card.front + "\n");
                foreach (var word in words)
                {
                    word.Display();
                }

                Console.ReadLine();
                
            }
        }
    }

    private void ChooseRandoms()
    {
        
    }
    private void UserHasLongEnoughDefs(List<CardSet> cardSets)
    {
        foreach (var cardSet in cardSets)
        {
            int cardSetMax = 0;
            List<int> cardSetWordLengthInts = new List<int>();
            foreach (var card in cardSet.GetFlashCards())
            {
                var words = card.back.Split(" ");
                cardSetWordLengthInts.Add(words.Length);
                if (words.Length > 5)
                {
                    card.AvailableOnBlankFill = true;
                }
            }
            
            cardSetMax = cardSetWordLengthInts.Max();
            if (cardSetMax > 5)
            {
                usableCardsets.Add(cardSet);
            }

            int usableCards = cardSetWordLengthInts.Count(item => item > 5);
            cardSet.UsableCards = usableCards;
        }
    }
}