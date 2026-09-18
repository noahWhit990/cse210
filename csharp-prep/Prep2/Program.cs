using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);
        string grade;

        if (percent >= 90)
        {
            grade = "A";
        }
        else if (percent >= 80)
        {
            grade = "B";
        }
        else if (percent >= 70)
        {
            grade = "C";
        }
        else if (percent >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        if (!(grade == "A" || grade == "F"))
        {
            if (percent % 10 >= 7)
            {
                grade += "+";
            }
            else if (percent % 10 <= 3)
            {
                grade += "-";
            }
        }
        else if (grade == "A")
        {
            if (percent % 10 <= 3 && percent < 100)
            {
                grade += "-";
            }
        }
        Console.WriteLine();
        Console.Write($"Your grade is {grade}. ");
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You failed. Better luck next time");
        }
    }
}