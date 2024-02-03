namespace Develop02;

public class Journal
{
    public List<Entry> entries = new List<Entry>();

  

    public void Display()
    {
        foreach (var entry in entries)
        {
            entry.Display();
        }      
    }
    
}