using System;
using System.Net.WebSockets;
using System.Security.Cryptography;

class NumberGame{
    int Guesses;
    int randomNumber;
    public NumberGame(){
        Random generatedNumber = new Random();
        randomNumber = generatedNumber.Next(1,500);
        MakeGuess();
    }
    private void MakeGuess(){
        do{
            System.Console.WriteLine("Make a guess of a number");
            int guess = int.Parse(Console.ReadLine());
            if(guess == randomNumber){
                System.Console.WriteLine("You got it!");
                break;
            }
            else if(guess > randomNumber){
                System.Console.WriteLine("Lower!");
            }
            else if(guess < randomNumber){
                System.Console.WriteLine("Higher!");
            }
        }while(true);

    }
}

class Program
{
    static void Main(string[] args)
    {
        string selection;
        do{
            System.Console.WriteLine("Welcome to number guesser!");
            System.Console.WriteLine("[1] Play the game!");
            System.Console.WriteLine("[2] Quit!");

            selection = Console.ReadLine();
            if(selection == "1"){
                NumberGame game = new NumberGame();
            }
            else if(selection == "2"){
                System.Console.WriteLine("Goodbye!");
                break;
            }
            else{
                System.Console.WriteLine("Invalid Option!");
            }
        }while(true);
    }
}