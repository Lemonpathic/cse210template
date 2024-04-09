using System;
using Final;

class Program
{

    static void Main(string[] args)
    {


        var app = new App();
        var menu = new Menu();
        menu.CreateFlashcardTemplates();

        while (app.isFinished == false)
        {
            menu.DisplayMenu();
        }
        
    }

}