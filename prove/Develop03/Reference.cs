using System.Runtime.CompilerServices;

namespace Develop03;

public class Reference
{
    private string book;
    private string chapter;
    private List<string> verses = new List<string>();
    private List<int> intVerses;
    private string exportString;
    public Reference(string book, string chapter, List<string> verseRef, List<string> verses)
    {
        this.book = book;
        this.chapter = chapter;
        this.verses = verses;
        this.intVerses = verseRef.Select(int.Parse).ToList();

        if (verseRef.Count > 1)
        {
            this.exportString = $"{book} {this.chapter}: {verseRef[0]}-{verseRef[verseRef.Count - 1]}";
        }
        else
        {
            this.exportString = verseRef[0];
        }
        

    }

    public string GetBook()
    {
        return book;
    }

    public List<string> GetVerses()
    {
        return verses;
    }

    public string GetChapter()
    {
        return chapter;
    }

    public string GetExportString()
    {
        return exportString;
    }

    public int returnLowestVerese()
    {
        return intVerses.Min();
    }
}