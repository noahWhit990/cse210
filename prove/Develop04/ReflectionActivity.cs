public class ReflectionActivity : Activity
{
    List<string> _reflectPrompts;

    public ReflectionActivity(string name, string description) : base(name, description)
    {
        _name = name;
        _description = description;
    }

    public void SetReflectPrompts(List<string> prompts)
    {
        _reflectPrompts = prompts;
    }

    public void RunReflect()
    {
        StartActivity();

        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {Random.Shared.GetItems(_prompts.ToArray(), 1)[0]} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may start in: ");
        ShowTimer(5);
        Console.WriteLine();

        while(DateTime.Now < endTime)
        {
            Console.Write($"> {Random.Shared.GetItems(_reflectPrompts.ToArray(), 1)[0]}? ");
            ShowSpinner(10);
            Console.WriteLine();
        }

        EndActivity();
    }
}