using System.Runtime.CompilerServices;

namespace Final;

public class Quiz:Activity
{
    private string title = "----------==[Quiz Review]==----------\n";
    private List<CardSet> cardSets = new List<CardSet>();
    public bool isFinished = false;
    
    
    public Quiz(List<CardSet> cardSets):base("Quiz Review", false)
    {
        foreach (var cardSet in cardSets)
        {
            if (cardSet.GetFlashCards().Count > 3)
            {
                this.cardSets.Add(cardSet);
            }
        }

        if (this.cardSets.Count == 0)
        {
            Console.WriteLine("Sorry you do not have any card sets large enough!");
            Thread.Sleep(3000);
            isFinished = true;
        }
        Console.Clear();
        while (!isFinished)
        {
            Menu();
            
        }
        
    }
    protected override void WelcomeMessage()
    {
        Console.WriteLine($"{title}" +
                          $"Welcome to {name}! Here you can practice your memorization of your flashcards through multiple choice quizzes\n");
        Thread.Sleep(5);
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
                                  $"Choose a card set:");
                int count = 0;
                foreach (var cardSet in cardSets)
                {
                    count++;
                    Console.WriteLine($"{count}. {cardSet.GetName()}");
                }

                int cardInput = int.Parse(Console.ReadLine()) - 1;
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
        List<Flashcard> flashcards = new List<Flashcard>();
        foreach (var cardSet in cardSets)
        {
            foreach (var card in cardSet.GetFlashCards())
            {
                flashcards.Add(card);
            }
        }

        int scoreTotal = cardSets[cardInput].GetFlashCards().Count;
        int scoreAmount = 0;
        foreach (var card in cardSets[cardInput].GetFlashCards())
        {
            bool cardSetReviewExit = false;
            
                Console.Clear();
                Console.WriteLine("----------==[Quiz]==----------\n");
                var question = new QuizQuestion(flashcards, card);
                
                var userAnswer = Console.ReadLine();
                if (question.IsCorrect(userAnswer))
                {
                    scoreAmount++;
                }
        }
        
        Console.Clear();
        Console.WriteLine("You Finished The Quiz!");
        Console.WriteLine($"SCORE: {scoreAmount}/{scoreTotal}");
        Thread.Sleep(3000);
        Console.Clear();
    }

    // private Flashcard GetFlashCardQuestion(List<Flashcard> flashcards)
    // {
    //     
    // }
}