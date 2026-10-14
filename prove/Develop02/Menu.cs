class Menu
{
    Journal journal = new Journal();
    // behaviors
    public void DisplayMenu()
    {
        int choice = 0;
        while (choice != 5)
        {
            Console.Write("Please Choose:\n1. Write\n2. Display\n3. Save\n4. Load\n5. Quit\nYour Choice: ");
            string response = Console.ReadLine();
            Console.WriteLine();
            while (! int.TryParse(response, out choice))
            {
                Console.WriteLine("Invalid choice. Your Choice: ");
                response = Console.ReadLine();
                Console.WriteLine();
            }

            if (choice == 1)
            {
                journal.Write();
            }
            else if (choice == 2)
            {
                journal.Display();
            }
            else if (choice == 3)
            {
                journal.Save();
            }
            else if (choice == 4)
            {
                journal.Load();
            }
        }
    }
}