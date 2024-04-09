namespace Final;

public class CardCreator : App
{
    private List<Flashcard> _flashcards = new List<Flashcard>();
    public bool cardCreatorFinished = false;
    private string title = "----------==[Card Creator]==----------\n";

    public void DisplayCardCreator()
    {
        Console.WriteLine($"{title}" +
                          $"{buffer}1.Create Flashcard\n" +
                          $"{buffer}2.Display Flashcards\n" +
                          $"{buffer}3.Finished");
        string input = Console.ReadLine();
        Console.Clear();
        switch (input)
        {
            case "1":
                Console.WriteLine($"{title}"+
                                  $"What is the front of the card?");
                string front = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"{title}"+
                                  $"What is the back of the card?");
                string back = Console.ReadLine();
                _flashcards.Add(new Flashcard(front, back));
                Console.Clear();
                break;
            case "2":
                Console.Clear();
                Console.WriteLine($"{title}");
                foreach (var VARIABLE in _flashcards)
                {
                    Console.WriteLine($"Front: {VARIABLE.front}");
                    Console.WriteLine($"Front: {VARIABLE.back}");
                    Console.WriteLine("-------------------------------------");
                }
                Console.WriteLine("PRESS ENTER TO CONTINUE");
                Console.ReadLine();
                Console.Clear();
                break;
            case "3":
                cardCreatorFinished = true;
                break;
                         
        }
    }

    public List<Flashcard> GetFlashCards()
    {
        return _flashcards;
    }
}