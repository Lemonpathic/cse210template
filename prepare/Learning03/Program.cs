using System;
using Learning03;

class Program
{
    static void Main(string[] args)
    {
        var resume1 = new Resume();
        resume1.fName = "Bryan";
        resume1.lName = "Wilson";
        
        var job1 = new Job();
        job1.jobTitle = "Software Engineer";
        job1.company = "ScrapBook Meta";
        job1.startYear = "2025";
        job1.endYear = "2055";

        var job2 = new Job();
        job2.jobTitle = "Janitor";
        job2.company = "Occupy Mars";
        job2.startYear = "2055";
        job2.endYear = "2087";
        
        resume1.Jobs.Add(job1);
        resume1.Jobs.Add(job2);
        
        resume1.Display();
        
        
    }
}