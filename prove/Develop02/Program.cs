using System;
using Develop02;
using System.Collections.Generic;
using System.IO;
class Program
{
    string filePath = "output.txt";

    public Journal journal;

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();

    }
    

    public void Run()
    {
        journal = new Journal();
        bool exit = false;
        do
        {
            Menu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    var entry = new Entry();
                    journal.entries.Add(entry);
                    Console.Clear();
                    break;
                case "2":
                    Console.Clear();
                    journal.Display();
                    break;
                case "3":
                    Console.Clear();
                    SaveToFile();
                    break;
                case "4":
                    Console.Clear();
                    LoadFromFile();
                    break;
                case "5":
                    Console.Clear();

                    exit = true;
                    break;
            }
            {
                
            }
        } while (!exit);
    }

    public void Menu()
    {
        Console.WriteLine("1. Create Entry");
        Console.WriteLine("2. Display Journal");
        Console.WriteLine("3. Saving");
        Console.WriteLine("4. Loading");
        Console.WriteLine("5. Exit");
    }
    private void SaveToFile()
    {
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            foreach (var journalEntry in journal.entries)
            {
                writer.WriteLine(journalEntry.exportString);
                writer.Flush();

            }
        }
    }

    private void LoadFromFile()
    {
        using (StreamReader sr = new StreamReader(filePath))
        {
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                var loadedEntry = new Entry(line);
                journal.entries.Add(loadedEntry);
                            
            }
        }
    }
}