using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions fraction1 = new Fractions();
        Fractions fraction2 = new Fractions(6);
        Fractions fraction3 = new Fractions(6, 7);

        Console.WriteLine(fraction1.GetFractionString());

        Console.WriteLine(fraction3.GetDecimalValue());
    }
}