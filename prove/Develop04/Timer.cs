namespace Develop04;

public class Timer
{
    private int _timeAmount;
    private int _originalTime;
    public bool _isFinished;
    private Thread _thread;

    public Timer(int timeAmount)
    {
        _timeAmount = timeAmount * 1000;
        _originalTime = _timeAmount;
        _isFinished = false;
        _thread = null;
    }
    
    
    
    public void Start()
    {
        _isFinished = false;
        _thread = new Thread(RunTimer);
        _thread.Start();
    }

    private void RunTimer()
    {
        while (!_isFinished)
        {
            if (_timeAmount <= 0)
            {
                _isFinished = true;
            }
            Thread.Sleep(1000);
            _timeAmount -= 1000;
        }
    }

    public int GetTimeLeft()
    {
        return _timeAmount;
    }
}
