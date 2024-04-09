namespace Final;

public abstract class Activity
{
    protected string name;
    protected bool isFinished = false;
    protected string buffer = Buffer.GetBuffer();

    protected Activity(string name, bool isFinished)
    {
        this.name = name;
        this.isFinished = isFinished;
    }

    protected abstract void WelcomeMessage();
    protected abstract void Menu();
    protected abstract void Completed();

}