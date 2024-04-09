using System.Runtime.CompilerServices;

namespace Final;

public class RegularReview:Activity
{
    private string title = "----------==[Card Review]==----------\n";
    private List<CardSet> cardSets;
    public RegularReview(List<CardSet> cardSets) : base("Regular Card Review", false)
    {
        Console.Clear();
        this.cardSets = cardSets;
        WelcomeMessage();
        while (!isFinished)
        {
            Console.Clear();
            Menu();
        }
    }
    protected override void WelcomeMessage()
    {
        Console.WriteLine($"{title}" +
                          $"Welcome to {name}! Here you can practice your memorization of your flashcards through simple review!\n");
        Thread.Sleep(5);
    }
    

    protected override void Menu()
    {
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
                                  $"Choose a card set:");
                int count = 0;
                foreach (var cardSet in cardSets)
                {
                    count++;
                    Console.WriteLine($"{count}. {cardSet.GetName()}");   
                }
                
                int cardInput = int.Parse(Console.ReadLine()) -1;
                RunReview(cardInput);
                
                break;
            case "2":
                Console.Clear();
                Random random = new Random();
                int randomInt = random.Next(0, cardSets.Count);
                Console.WriteLine($"{title}\n" +
                                  $"Reviewing: {cardSets[randomInt].GetName()}");
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
        foreach (var card in cardSets[cardInput].GetFlashCards())
        {
            bool cardSetReviewExit = false;

            do
            {
                Console.Clear();
                Console.WriteLine("----------==[FRONT]==----------\n");
                Console.WriteLine(card.front + "\n");
                Console.WriteLine("Press ENTER to see the back term.");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("----------==[BACK]==----------\n\n" +
                                  $"{card.back}\n\n" +
                                  $"Press ENTER to see the next card. Press R to repeat this card");
                string contInput = Console.ReadLine().ToLower();
                if (contInput == "r")
                {
                    cardSetReviewExit = false;
                }
                else
                {
                    cardSetReviewExit = true;
                            
                }
            } while (!cardSetReviewExit);
        }
    }
}