using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");

        // ask name
        Person person = new Person();
        Console.WriteLine("What is your first name?");
        person.setFirstName(Console.ReadLine());

        Console.WriteLine("what is your last name?");
    }
}