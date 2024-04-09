namespace Final;

public class Menu : App
{
    private List<CardSet> cardSets = new List<CardSet>();

    public void CreateFlashcardTemplates()
    {
        // Create a list of flashcards for the Egypt template
        List<Flashcard> egyptTemplateFlashcards = new List<Flashcard>
        {
            new Flashcard("Nile River", "What is the longest river in the world?"),
            new Flashcard("Pyramids", "What ancient structures are found primarily in Egypt and Sudan?"),
            new Flashcard("Pharaoh", "What title was given to the rulers of ancient Egypt?"),
            new Flashcard("Hieroglyphics", "What is the name of the writing system used by ancient Egyptians?"),
            new Flashcard("Sphinx", "What mythical creature with the head of a human and the body of a lion is found in Egypt?")
        };

        CardSet egyptTemplate = new CardSet(egyptTemplateFlashcards);
        egyptTemplate.SetName("Ancient Egypt");

        cardSets.Add(egyptTemplate);

        List<Flashcard> csIntroTemplateFlashcards = new List<Flashcard>
        {
            new Flashcard("Algorithm", "What is a sequence of steps to solve a problem?"),
            new Flashcard("Variable", "What is a placeholder for a value that can change?"),
            new Flashcard("Loop", "What programming construct repeats a set of instructions multiple times?"),
            new Flashcard("Boolean", "What data type has only two possible values: true or false?"),
            new Flashcard("Function", "What is a named block of code that performs a specific task?")
        };

        CardSet csIntroTemplate = new CardSet(csIntroTemplateFlashcards);
        csIntroTemplate.SetName("Intro to Computer Science");

        cardSets.Add(csIntroTemplate);
    }
    public void DisplayMenu()
    {
        Console.WriteLine("----------==[HOME]==----------\n" +
                          "Choose an option from the menu: \n" +
                          $"{buffer}1. Create Flashcard Set\n" +
                          $"{buffer}2. Review Flashcards \n" +
                          $"{buffer}3. Quit");
        string input = Console.ReadLine();
        Console.Clear();

        switch (input)
        {
            case "1":
                Console.Clear();
                CardCreator cardCreator = new CardCreator();
                while (!cardCreator.cardCreatorFinished)
                {
                    cardCreator.DisplayCardCreator();
                }
                Console.WriteLine($"----------==[Card Creator]==----------\n" +
                                  $"What is the name of this card set?");
                string name = Console.ReadLine();
                CardSet CreatedCardSet = new CardSet(cardCreator.GetFlashCards());
                CreatedCardSet.SetName(name);
                cardSets.Add(CreatedCardSet);
                Console.Clear();

                
                break;
            case "2":
                Console.Clear();
                Console.WriteLine("----------==[HOME]==----------\n" +
                                  "Choose a review option from the menu: \n" +
                                  $"{buffer}1. Simple Review\n" +
                                  $"{buffer}2. Quiz Review \n" +
                                  $"{buffer}3. Blank Space Baby\n" +
                                  $"{buffer}4. Quit");
                string reviewInput = Console.ReadLine();
                switch (reviewInput)
                {
                    case "1":
                        Console.Clear();
                        new RegularReview(cardSets);
                        break;
                    case "2":
                        Console.Clear();
                        new Quiz(cardSets);
                        break;
                    case "3":
                        Console.Clear();
                        new BlankFill(cardSets);
                        break;
                }
                break;
            case "3":
                Environment.Exit(0);
                break;
            
        }
    }

    
} 