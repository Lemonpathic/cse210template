namespace Final;

public class CardSet(List<Flashcard> flashcards)
{
    private string name;
    public int UsableCards { get; set; }

    public List<Flashcard> GetFlashCards()
    {
        return flashcards;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return name;
}
}