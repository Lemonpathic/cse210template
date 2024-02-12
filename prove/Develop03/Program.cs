using System;
using Develop03;

class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
    
        var ref1 = new Reference("Alma", "7", new[] { "11", "12", "13" }, new []{"I Nephi am a Man of God",
            "My father is Lehi, a good man."});
        var scripture1 = new Scripture(ref1.GetVerses());

        Console.WriteLine(ref1.GetExportString());
        scripture1.Display();
        Console.ReadLine();
        
        bool quit = false;
        while (!quit)
        {
            Console.Clear();
            Console.WriteLine(ref1.GetExportString());
            scripture1.ChooseRandomWord();
            if (Console.ReadLine().ToUpper() == "Q")
            {
                quit = true;
            }
        }
    }

}