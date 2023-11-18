
using System;

class Program
{
    static void Main()
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(2);
        Fraction fraction3 = new Fraction(2, 3);

        Console.WriteLine(fraction1.GetFractionalView());
        Console.WriteLine(fraction2.GetFractionalView());
        Console.WriteLine(fraction3.GetFractionalView());

        fraction1.SetNumbers(5, 6);
        Console.WriteLine(fraction1.GetFractionalView());
        Console.WriteLine(fraction1.GetDecimalView());


    }
}