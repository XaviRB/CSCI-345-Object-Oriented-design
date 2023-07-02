using System;
//TOPIC:     Design Patterns – Listener Pattern – Timer
//CLASS:     Timer and TimerListener
class Program{
    static void Main(){
        //Create a new Timer/TimerListener object 
        Timer timer = new Timer();
        TimerListener sally = new TimerListener("Sally");

        //Initalizing RegisterTimerListener, SetTimePeriod and Activate 
        timer.RegisterTimerListener(sally);
        timer.SetTimePeriod(3);
        timer.Activate();

        Console.Read();
    }
}
