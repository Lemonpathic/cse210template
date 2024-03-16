namespace Develop05;

public class Checklist : Goal
{
    private int streakAmount;
    private int streakCount;
    private int bonus;
    public Checklist(int points, string name, string description, int streakAmount, int streakCount, int bonusPoints ) :base(points, name, description)
    {
        this.streakAmount = streakAmount;
        this.streakCount = streakCount;
        this.bonus = bonusPoints;
    }

    public Checklist(string[] list)
    {
        name = list[1];
        description = list[2];
        points = int.Parse(list[3]);
        streakAmount = int.Parse(list[5]);
        streakCount = int.Parse(list[4]);
        bonus = int.Parse(list[6]);
    }

    public override string Display()
    {
        return ($"[ ] {name}, {description}, {points}, {streakCount}/{streakAmount}");
    }

    public override void Export()
    {
        const string delimiter = "|/|";
        using var writer = new StreamWriter("output.txt", true);
        writer.WriteLine($"CG{delimiter}{name}{delimiter}{description}{delimiter}{points}{delimiter}{streakCount}{delimiter}{streakAmount}{delimiter}{bonus}");
        writer.Close();
    }
    
    public override int Completed()
    {
        streakCount += 1;
        if (streakCount != streakAmount) return points;
        streakCount = 0;
        return bonus + points;
    }

}