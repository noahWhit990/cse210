using System;

class Program
{
    static void Main(string[] args)
    {
        int input = 0;

        int breatheNumber = 0;
        int reflectNumber = 0;
        int listNumber = 0;

        int breatheTime = 0;
        int reflectTime = 0;
        int listTime = 0;

        while(input != 5)
        {
            Console.Write("""
            Menu Options:
            1. Start breathing activity
            2. Start reflect activity
            3. Start listing activity
            4. Activity Report
            5. Quit
            """);
            Console.Write("\nSelect a choice from the menu: ");
            input = int.Parse(Console.ReadLine());

            if(input == 1)
            {
                BreathingActivity breathe = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                
                breathe.RunBreathe();

                breatheNumber++;
                breatheTime += breathe.GetDuration();
            }
            else if(input == 2)
            {
                ReflectionActivity reflect = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                List<string> prompts = new List<string>();
                prompts.Add("Think of a time when you stood up for someone else.");
                prompts.Add("Think of a time when you did something really difficult.");
                prompts.Add("Think of a time when you helped someone in need.");
                prompts.Add("Think of a time when you did something truly selfless.");

                List<string> reflectPrompts = new List<string>();
                reflectPrompts.Add("Why was this experience meaningful to you?");
                reflectPrompts.Add("Have you ever done anything like this before?");
                reflectPrompts.Add("How did you get started?");
                reflectPrompts.Add("How did you feel when it was complete?");
                reflectPrompts.Add("What made this time different than other times when you were not as successful?");
                reflectPrompts.Add("What is your favorite thing about this experience?");
                reflectPrompts.Add("What could you learn from this experience that applies to other situations?");
                reflectPrompts.Add("What did you learn about yourself through this experience?");
                reflectPrompts.Add("How can you keep this experience in mind in the future?");

                reflect.SetPrompts(prompts);
                reflect.SetReflectPrompts(reflectPrompts);

                reflect.RunReflect();

                reflectNumber++;
                reflectTime += reflect.GetDuration();
            }
            else if(input == 3)
            {
                ListingActivity list = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                
                List<string> prompts = new List<string>();
                prompts.Add("Who are people that you appreciate?");
                prompts.Add("What are personal strengths of yours?");
                prompts.Add("Who are people that you have helped this week?");
                prompts.Add("When have you felt the Holy Ghost this month?");
                prompts.Add("Who are some of your personal heroes?");

                list.SetPrompts(prompts);

                list.RunListing();

                listNumber++;
                listTime += list.GetDuration();
            }
            else if(input == 4)
            {
                Console.WriteLine("\nA report of all activities:");
                Console.WriteLine($"Breathing: {breatheNumber} times - {breatheTime} seconds total.");
                Console.WriteLine($"Reflect: {reflectNumber} times - {reflectTime} seconds total.");
                Console.WriteLine($"Listing: {listNumber} times - {listTime} seconds total.");
                
                Console.WriteLine();

                Console.Write("Press enter to continue ");
                Console.ReadLine();

                Console.Clear();
            }
            else
            {
                if(input != 5)
                {
                    Console.WriteLine("Invalid. Please enter 1, 2, 3, or 4");
                    Console.Clear();
                }
            }
        }
    }
}