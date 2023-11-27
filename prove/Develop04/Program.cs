using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("How many seconds would you like your session to be?");
        string input = Console.ReadLine();

        Activity option = new Activity("");
        option.ChooseActivity();
        
        Timer timer = new Timer(0);
        int seconds = int.Parse(input);
        bool done = timer.StartTimer(seconds);


        Console.WriteLine("Complete! Good job!");

    }
}


// 