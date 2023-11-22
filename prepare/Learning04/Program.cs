using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!\n");

        Assignment assignment1 = new Assignment("Harry", "Fractions", 7.3, 5, 7);
        Console.WriteLine(assignment1.showAssignment());
        
    }
}