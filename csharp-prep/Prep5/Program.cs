using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static void PromptUserBirthYear(out int birthYear)
        {
            Console.Write("Please enter your year of birth: ");
            birthYear = int.Parse(Console.ReadLine());
        }

        static int SquareNumber(int number)
        {
            number = number * number;
            return number;
        }

        static void DisplayResult(string name, int numberSquared, int birthYear)
        {
            Console.WriteLine($"{name}, the square of your number is {numberSquared}");
            Console.WriteLine($"{name}, you will turn {2026 - birthYear} this year.");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int birthYear;
        int number = PromptUserNumber();
        PromptUserBirthYear(out birthYear);
        int numberSquared = SquareNumber(number);
        DisplayResult(name, numberSquared, birthYear);
    }
}