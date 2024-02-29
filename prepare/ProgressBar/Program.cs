using System;
using System.Threading;

class Program
{
    static bool stopTyping = false;

    static void Main(string[] args)
    {
        Console.WriteLine("You have 30 seconds to type something:");

        // Start a thread to monitor user input
        Thread inputThread = new Thread(ReadUserInput);
        inputThread.Start();

        // Wait for 30 seconds
        Thread.Sleep(5000);

        // Set the flag to stop typing
        stopTyping = true;

        Console.WriteLine("\nTime's up! You cannot type anymore.");
    }

    static void ReadUserInput()
    {
        while (!stopTyping)
        {
            string input = Console.ReadLine();
            Console.WriteLine("You typed: " + input);
        }
    }
}