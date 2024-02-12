using System.ComponentModel;
using System.Reflection;
using System.Threading.Channels;

namespace Learning03;

public class Job
{
    private string company;
    private string jobTitle;
    private string startYear;
    private string endYear;

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