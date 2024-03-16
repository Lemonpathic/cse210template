using System.Xml;

namespace Develop05;

public class Simple : Goal
{
    private bool isFinished;
    public Simple(int points, string name, string description, bool isFinished) :base(points, name, description)
    {
        this.isFinished = isFinished;
    }

    public Simple(string[] fileString)
    {
        name = fileString[1];
        description = fileString[2];
        points = int.Parse(fileString[3]);
        isFinished = bool.Parse(fileString[4]);
    }
    public override string Display()
    {

        return(
        isFinished
            ? $"[X] {name}, {description}, {points}"
            : $"[ ] {name}, {description}, {points}");
    }

    public override void Export()
    {
        const string delimiter = "|/|";
        using var writer = new StreamWriter("output.txt", true);
        writer.WriteLine($"SG{delimiter}{name}{delimiter}{description}{delimiter}{points}{delimiter}{isFinished}");
        writer.Close();
    }

    public override int Completed()
    {
        if (!isFinished)
        {
            isFinished = true;
            return points;
        }

        return 0;
    }
    
}