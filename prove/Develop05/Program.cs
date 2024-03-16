using System;
using Develop05;

class Program
{
    static void Main(string[] args)
    {
        var quest = new Quest();

        while (quest.finished == false)
        {
            quest.Menu();
        }
        
    }

    }
