namespace Learning03;

public class Resume
{
    public string fName;
    public string lName;
    public List<Job> Jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Resume of {fName} {lName}:");
        foreach (var job in Jobs)
        {
         job.Display();   
        }
    }
}