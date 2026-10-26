using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        Console.WriteLine("Welcome to the scripture memorization program!");
        Console.Write("Would you like to provide your own scripture? (yes/no): ");
        string response = Console.ReadLine();
        Scripture scripture = new Scripture();
        Reference reference = new Reference();
        if (response.ToLower() == "yes")
        {
            Console.Write("Please enter the book name: ");
            string book = Console.ReadLine();
            Console.Write("Please enter the chapter: ");
            int chapter = int.Parse(Console.ReadLine());
            Console.Write("Please enter the starting verse: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Please enter the end verse (if there's only one verse, enter 0): ");
            int end = int.Parse(Console.ReadLine());
            Console.Write("Please paste in the scripture (exclude verse numbers): ");
            string scriptureText = Console.ReadLine();
            reference.SetBook(book);
            reference.SetChapter(chapter);
            reference.SetStartVerse(start);
            reference.SetEndVerse(end);
            scripture.SetScripture(scriptureText);
        }
        else
        {
            Console.WriteLine("Using a preset scripture:");
            reference.SetBook("John");
            reference.SetChapter(3);
            reference.SetStartVerse(16);
            scripture.SetScripture("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        }

        Console.Clear();
        Console.WriteLine($"{reference.GetDisplayString()} - {scripture.GetScripture()}");

        while (input.ToLower() != "quit" && !scripture.AllHidden())
        {
            Console.Write("Press enter to hide words or 'quit' to quit ");
            input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            Console.Clear();
            Console.WriteLine($"{reference.GetDisplayString()} - {scripture.Memorize()}");
        }
    }
}