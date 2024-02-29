namespace Learning02;

public class Timer
{
    private int time;
    private Thread thread;
    public bool isRunning;

    public Timer(int time)
    {
        this.time = time;
        thread = new Thread(CountDown);
    }

    private void CountDown()
    {
        while (time > 0)
        {
            Thread.Sleep(1000);
            time--;
        }

        isRunning = false;


    }

    public void Start()
    {
        thread.IsBackground = true;
        thread.Start();
    }
    

}

