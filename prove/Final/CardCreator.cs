namespace Develop05;

public class CardCreator : App
{
    private string buffer = "   ";
    private string 
    public CardCreator()
    {
        Console.WriteLine("----------==[Card Creator]==----------\n" +
                          $"{buffer}1.Create Flashcard\n" +
                          $"{buffer}2.Display Flashcards\n" +
                          $"{buffer}3.Quit");
        input = Console.ReadLine();
        Console.Clear();
        switch (input)
        {
            case "1":
                Console.WriteLine($"----------==[Card Creator]==----------\n" +
                                  $"");
                break;
            case "2":
                break;
            case "3":
                break;
                         
        }
    }
    
}