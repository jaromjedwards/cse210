using System;

class Activity
{
    private string name;

    public Activity(string name)
    {
        this.name = name;
    }

    public void ChooseActivity(string option){
        
        if (option == "1"){
            Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

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
        else if (option == "2"){
            Console.WriteLine("You chose Reflection Remedy");
            Console.WriteLine("");
            }
        else if (option == "3"){
            Console.WriteLine("You chose Discover You");
            }

    }
}