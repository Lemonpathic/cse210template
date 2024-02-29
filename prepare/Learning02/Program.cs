using System;
using Learning02;


class Program
{
    static bool finished = false;
    private static List<Pig> pigs = new List<Pig>();
    static void Main(string[] args)
    {
   
        var counter = 0;
        while (!finished)
        {
            Console.WriteLine("Press P to start");
            var input = Console.ReadLine();
            if (input == "p")
            {
                var pig = new Pig(counter);
                pigs.Add(pig);
                pig.Start();
                counter++;
                
            }
        }
    }
}