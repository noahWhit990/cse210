public class Activity
{
    private protected string _name;
    private protected string _description;
    private protected int _duration;
    private protected List<string> _prompts;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like this activity to be? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get Ready...\n");
        ShowSpinner(5);
    }

    public void EndActivity()
    {
        Console.WriteLine("Well Done!!\n");
        ShowSpinner(5);

        Console.WriteLine($"You have completed {_duration} seconds of the {_name}!");
        ShowSpinner(5);
        
        Console.Clear();
    }

    public void ShowSpinner(int d)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(d);

        while(DateTime.Now < endTime)
        {
            Console.Write("|");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(100);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(100);
            Console.Write("\b \b");
        }
    }

    public void ShowTimer(int d)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(d);

        int i = d;

        while(DateTime.Now < endTime)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i--;
        }
    }

    public void SetDuration(int d)
    {
        _duration = d;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetPrompts(List<string> prompts)
    {
        _prompts = prompts;
    }
}