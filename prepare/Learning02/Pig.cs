namespace Learning02;

public class Pig
{
    private string name = "pig";
    private Thread thread;
    private bool dead = false;
    private int time;

    public Pig(int count)
    {
        this.name += count;
        thread = new Thread(AgeUp);
        thread.IsBackground = true;
    }

    private void AgeUp()
    {
        
        while (!dead)
        {
            Console.WriteLine($"{name} is {time} seconds old");
            Thread.Sleep(1000);
            time++;
        }
    }

    public void Start()
    {
        thread.Start();
    }
}