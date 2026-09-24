using System;

class Program
{
    static void Main(string[] args)
    {
        string input;
        do
        {
            int guess;
            int number;
            int guesses = 0;

            Random randomNumber = new Random();
            number = randomNumber.Next(1, 101);
            
            do
            {
                Console.Write("Please guess the magic number (1-100): ");
                string response = Console.ReadLine();
                guess = int.Parse(response);
                
                if (guess == number)
                {
                    Console.WriteLine("Congratulations! You guessed it!");
                    guesses++;
                    Console.WriteLine($"It took you {guesses} guesses.");
                }
                else if (guess < number)
                {
                    Console.WriteLine("The number is higher.");
                    guesses++;
                }
                else if (guess > number)
                {
                    Console.WriteLine("The number is lower.");
                    guesses++;
                }
                else
                {
                    Console.WriteLine("Please enter a valid response.");
                }
            } while (guess != number);
            Console.Write("Do you want to play again (yes/no)? ");
            input = Console.ReadLine();
        } while (input == "yes");
    }
}