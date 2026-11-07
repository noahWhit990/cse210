public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
        _name = name;
        _description = description;
    }
    
    public void BreatheIn()
    { 
        Console.Write("Breathe in...");
        ShowTimer(4);
        Console.WriteLine();
    }

    public void BreatheOut()
    {
        Console.Write("Breathe out...");
        ShowTimer(4);
        Console.WriteLine();
    }

    public void RunBreathe()
    {
        StartActivity();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
            BreatheIn();
            BreatheOut();
        }

        EndActivity();
    }
}