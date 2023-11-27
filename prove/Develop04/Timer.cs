using System;

class Timer
{
    private int timer;

    public Timer(int timer){
        this.timer = timer;
    }

    public bool StartTimer(int seconds)
    {
        while (seconds != 0)
        {   
            Thread.Sleep(1000);
            seconds--;
        }
        // timer done
        return true;
    }


}