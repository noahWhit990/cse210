using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input = -1;
        int sum = 0;
        float average;
        int largest = 0;

        while (input != 0)
        {
            Console.Write("Please enter a series of whole numbers (0 to quit): ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
        }

        foreach (int number in numbers)
        {
            sum += number;

            if (number > largest)
            {
                largest = number;
            }
        }
        average = (float)sum / numbers.Count;
        Console.WriteLine($"The sum of all the numbers is {sum}");
        Console.WriteLine($"The average of all the numbers is {average}");
        Console.WriteLine($"The largest number in the number list is {largest}");
    }
}