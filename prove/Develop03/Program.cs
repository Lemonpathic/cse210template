using System;
using Develop03;

class Program
{
    
    static void Main(string[] args)
    {
        Console.Clear();
        var ref1 = new Reference("Alma", "7", new List<string>{"11", "12"}, new List<string>{
            "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people.",
            "And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities."
        });

        var scripture1 = new Scripture(ref1.GetVerses(), ref1.returnLowestVerese());
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