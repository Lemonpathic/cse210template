namespace Develop05;

public class Quest
{
    private int pointsTotal = 0;
    public bool finished = false;
    public List<Goal> goals = new List<Goal>();

    public Quest()
    {

    }

    private void RecordEvent()
    {
        Console.WriteLine("What goal would you like to record an event for?");
        Display();
        var input = int.Parse(Console.ReadLine());
        pointsTotal += goals[input - 1].Completed();
    }
    public int GetPoints()
    {
        return pointsTotal;
    }

    public void AddPoints(int pointsAmount)
    {
        pointsTotal += pointsAmount;
    }

    private void import()
    {
        using (var reader = new StreamReader("output.txt"))
        {
            string line;
            pointsTotal = int.Parse(reader.ReadLine());
            while ((line = reader.ReadLine()) != null)
            {
                var lineSplit = line.Split("|/|");
                switch (lineSplit[0])
                {
                    case "SG":
                        var newGoal = new Simple(lineSplit);
                        goals.Add(newGoal);
                        break;
                    case "EG":
                        var newGoalEternal = new Eternal(lineSplit);
                        goals.Add(newGoalEternal);
                        break;
                    case "CG":
                        var newGoalChecklist = new Checklist(lineSplit);
                        goals.Add(newGoalChecklist);
                        break;
                }
            }
        }
    }

    public void Display()
    {
        Console.WriteLine($"Points: {pointsTotal}");
        int count = 0;
        foreach (var goal in goals)
        {
            count += 1;
            Console.WriteLine(
            $"{count}. {goal.Display()}");
        }
    }
    

    public void Menu()
    {
        Console.WriteLine($"Points: {pointsTotal}");
        Console.WriteLine("Menu Options:\n" +
                          "1. Create New Goal\n" +
                          "2. List Goals\n" +
                          "3. Save Goals\n" +
                          "4. Load Goals\n" +
                          "5. Record Event\n" +
                          "6. Quit");
        string input = Console.ReadLine();
        //Console.Clear();
        switch (input)
        {
            case "1":
                Console.Clear();
                Console.WriteLine("What is the name of this goal?");
                string name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("What is the description of this goal?");
                string desc = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("How many points is this goal worth?");
                int points = int.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("What type of Goal is this:\n" +
                                  "1. Simple Goal\n" +
                                  "2. Eternal Goal\n" +
                                  "3. Checklist Goal");
                string goalType = Console.ReadLine();
                Console.Clear();
                switch (goalType)
                {
                    case "1":
                        Goal goalSimple = new Simple(points, name, desc, false);
                        goals.Add(goalSimple);
                        break;
                    case "2":
                        Goal goalEternal = new Eternal(points, name, desc);
                        goals.Add(goalEternal);
                        break;
                    case "3":
                        Console.WriteLine(
                            $"How many times do you need to complete this goal to receive the bonus award?");
                        int streak = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine($"How many points will you receive after completing the goal {streak} times?");
                        int bonus = int.Parse(Console.ReadLine());
                        Console.Clear();

                        Goal goalChecklist = new Checklist(points, name, desc, streak, 0, bonus);
                        goals.Add(goalChecklist);
                        break;
                }



                break;
            case "2":
                Console.Clear();
                Display();
                Console.WriteLine("Press ENTER to exit");
                Console.ReadLine();
                Console.Clear();
                break;
            case "3":
                Console.Clear();
                var writer = new StreamWriter("output.txt");
                writer.WriteLine(pointsTotal);
                writer.Close();
                foreach (var VARIABLE in goals)
                {
                    VARIABLE.Export();
                }
                break;
            case "4":
                Console.Clear();
                import();
                break;
            case "5":
                Console.Clear();
                RecordEvent();
                Console.Clear();
                break;
            case "6":
                Console.Clear();
                finished = true;
                break;
        }
    }
    
}