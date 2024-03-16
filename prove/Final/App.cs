namespace Final;

public class Menu
{
    private List<Flashcard> flashcards = new List<Flashcard>();

    public Menu()
    {
        
    }

    public void DisplayMenu()
    {
        Console.WriteLine("-----[HOME]-----\n" +
                          "Choose and option from the menu: \n" +
                          "\t1. Create Flashcard Set\n" +
                          "\t2. Review Flashcards \n" +
                          "\t3. Visit The Shop \n" +
                          "\t4. Quit");
    }
}