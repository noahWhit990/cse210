public class ListingActivity : Activity
{
    public ListingActivity(string name, string description) : base(name, description)
    {
        _name = name;
        _description = description;
    }

    public void RunListing()
    {
        StartActivity();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {Random.Shared.GetItems(_prompts.ToArray(), 1)[0]} ---");
        Console.Write("You may begin in: ");
        ShowTimer(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        int items = 0;

        while(DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            items++;
        }

        Console.WriteLine($"You listed {items} items!\n");
        EndActivity();
    }
}