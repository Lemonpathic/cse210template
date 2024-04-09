namespace Final;

public class Flashcard
{
    public string front;
    public string back;
    public bool AvailableOnBlankFill { get; set; }

    public Flashcard(string front, string back)
    {
        this.front = front;
        this.back = back;
    }
    
}