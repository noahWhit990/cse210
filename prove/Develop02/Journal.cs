class Journal
{
    // attributes
    public List<Entry> _entries = new List<Entry>();
    public List<string> _prompts = new List<string>();

    // behaviors
    public void Write()
    {
        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();
        string[] lines = System.IO.File.ReadAllLines("prompts.txt");
        _prompts = [];
        foreach (string line in lines)
        {
            _prompts.Add(line);
        }

        Entry entry = new Entry();
        entry._prompt = Random.Shared.GetItems(_prompts.ToArray(), 1)[0];
        entry._date = date;

        Console.WriteLine(entry._prompt);
        entry._response = Console.ReadLine();
        Console.Write("Save as favorite? ");
        string input = Console.ReadLine();
        
        if (input.ToLower() == "yes")
        {
            entry._favorite = true;
        }
        else
        {
            entry._favorite = false;
        }

        _entries.Add(entry);
    }

    public void Display()
    {
        foreach(Entry entry in _entries)
        {
            string[] dateParts = entry._date.Split("/");
            int day = int.Parse(dateParts[1]);

            entry.Display();
            Console.WriteLine();
        }
    }

    public void Save()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}|{entry._favorite}");
            }
        }
    }

    public void Load()
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        _entries = [];

        foreach (string line in lines)
        {
            Entry entry = new Entry();
            string[] parts = line.Split("|");

            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];

            _entries.Add(entry);
        }
    }
}