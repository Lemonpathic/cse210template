using System;

class Program
{
    static void Main(string[] args)
    {

        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome buddy!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("What is your name?");
            return Console.ReadLine();
        }

        static string PromptUserPhoneNumber()
        {
            Console.WriteLine("What is your phone number?");
            return Console.ReadLine();
        }

        static int SquareNumber()
        {
            Console.WriteLine("Give me a number to square!"); 
            int number = int.Parse(Console.ReadLine());
            return number * number;
        }

        static void DisplayResult()
        {
            WelcomeMessage();
            var name = PromptUserName();
           var phoneNumber = PromptUserPhoneNumber();
            var squared = SquareNumber();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine(name);
            Console.WriteLine(phoneNumber);
            Console.WriteLine(squared);
        }
        DisplayResult();
    }
}