using System;

class Activity
{
    private string option;

    public Activity(string option)

    {
        // name
        // duration
        // description

        this.option = option;
    }

    public void ChooseActivity(){

        Console.WriteLine("What mindfulness activity would you like to do? (type a number) \n1. Breathing Excersise \n2. Refelection Remedy \n3. Discover You \n4. Exit");

        string option = Console.ReadLine();
        
        if (option == "1"){
            Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."); 
            StartActivity();

        }

        else if (option == "2"){
            Console.WriteLine("You chose Reflection Remedy");
            Console.WriteLine("");
            StartActivity();
            }
        else if (option == "3"){
            Console.WriteLine("You chose Discover You");
            StartActivity();
            }
    }

    public void StartActivity(){

        int count = 0;
            while (count < 3)
            {
                Console.Write("Get ready +");
                Thread.Sleep(1000);
                Console.Write("\r");
                Console.Write("Get ready -");
                Thread.Sleep(1000);
                Console.Write("\r");
                count++;
            }
            Console.Write("\b \b");

        
    }
}