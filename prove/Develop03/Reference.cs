using System.Runtime.CompilerServices;

namespace Develop03;

public class Reference
{
    private string book;
    private string chapter;
    private string[] verses;
    private string exportString;
    public Reference(string book, string chapter, string[] verseRef, string[] verses)
    {
        this.book = book;
        this.chapter = chapter;
        this.verses = verses;
        

        if (verseRef.Length > 1)
        {
            this.exportString = $"{book} {this.chapter}: {verseRef[0]}-{verseRef[verseRef.Length - 1]}";
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

    public string[] GetVerses()
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
    
}