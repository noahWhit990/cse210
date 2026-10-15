using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction construct1 = new Fraction();
        Console.WriteLine(construct1.GetFractionString());
        Console.WriteLine(construct1.GetDecimalValue());

        Fraction construct2 = new Fraction(5);
        Console.WriteLine(construct2.GetFractionString());
        Console.WriteLine(construct2.GetDecimalValue());

        Fraction construct3 = new Fraction(6, 7);
        Console.WriteLine(construct3.GetFractionString());
        Console.WriteLine(construct3.GetDecimalValue());

        Random random = new Random();
        Fraction construct4 = new Fraction();

        for(int i = 0; i < 20; i++)
        {
            int top = random.Next(1, 101);
            int bottom = random.Next(1, 101);

            construct4.SetTop(top);
            construct4.SetBottom(bottom);

            string fractionString = construct4.GetFractionString();
            double fractionNumber = construct4.GetDecimalValue();
            Console.WriteLine($"Fraction {i + 1}: string: {fractionString} number: {fractionNumber}");
        }
    }
}