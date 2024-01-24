using System.ComponentModel;
using System.Reflection;
using System.Threading.Channels;

namespace Learning03;

public class Job
{
    public string company;
    public string jobTitle;
    public string startYear;
    public string endYear;

    public Job(string company, string jobTitle, string startYear, string endYear)
    {
        this.company = company;
        this.jobTitle = jobTitle;
        this.startYear = startYear;
        this.endYear = endYear;
    }
    public void Display()
    {
        Console.WriteLine($"{jobTitle} ({company}) {startYear} - {endYear}");
    }
    
}