using System;
using Develop04;
using Activity = System.Diagnostics.Activity;

class Program
{
    public void Menu()
    {
        Console.WriteLine("Choose an activity:\n" +
                          "1.Breathing Activity \n" +
                          "2.Reflecting Activity \n" +
                          "3.Listing Activity \n");
        
        Console.Write("Select an activity from the list:");
        var input = Console.ReadLine();

        switch (input)
        {
            case "1":
                new BreathingExercise().Display(null);
                break;   
            
            case "2": 
                new Reflection().Display(null);
                break;
            
            case "3":
                new HolyGhostMoments().Display(null);
                break;
        }
    }

    static void Main(string[] args)
    {
        var finished = false;
        var program = new Program();
        while (!finished)
        {
            program.Menu();
        }
    }

   
}