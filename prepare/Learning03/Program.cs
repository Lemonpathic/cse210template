using System;
using Learning03;

class Program
{
    static void Main(string[] args)
    {
        var resume1 = new Resume();
        resume1.fName = "Bryan";
        resume1.lName = "Wilson";
        
        var job1 = new Job("ScrapBook Meta","Software Engineer", "2025", "2055");

        var job2 = new Job("Occupy Mars", "Janitor", "2055", "2087");
        
        resume1.Jobs.Add(job1);
        resume1.Jobs.Add(job2);
        
        resume1.Display();
        
        
    }
}