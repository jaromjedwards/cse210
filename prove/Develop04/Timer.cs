using System;

class Timer
{
    private int time;

    public Timer(int time){
        this.time = time;
    }

    public void StartTimer(int seconds){
        while (seconds != 0)
        {   
            Console.WriteLine(seconds);
            Thread.Sleep(1000);
            seconds--;
            Console.Write("\b \b");
        }
        
        Console.WriteLine("Complete! Good job!");
    }
}