namespace Develop05;

public class Eternal : Goal
{
    public Eternal(int points, string name, string description) : base(points, name, description)
    {
    }

    public Eternal(string[] list)
    {
        points = int.Parse(list[3]);
        name = list[1];
        description = list[2];
    }

    public override string Display()
    {
        return ($"[ ] {name}, {description}, {points}");
    }

    public override void Export()
    {
        const string delimiter = "|/|";
        using var writer = new StreamWriter("output.txt", true);
        writer.WriteLine($"EG{delimiter}{name}{delimiter}{description}{delimiter}{points}");
        writer.Close();
    }

    public override int Completed()
    {
        return points;
    }
}