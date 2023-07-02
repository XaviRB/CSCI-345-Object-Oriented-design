using System.Threading;
/* 
# Author: Xavier Rodriguez        
# Description: Timer class sets a timer for a specific amount of time in seconds and then notify a registered #              TimerListener object when the time is up. The methods SetTimePeriod, RegisterTimerListener and
#              Activate helps define the state it is in.
# Date: 2/15/23          
# Specification: Design Patterns – Listener Pattern – Timer
*/
class Timer {
    /*       
	# Fields 
	#   timerPeriod: Private field stores seconds the timer should be set for
    #   listener: Private field stores reference to TimerListener object
    #   MILLISECONDS_PER_SECONDS: int of 1000 to help find the amount of time the thread is suspended
	*/
    private int timerPeriod;
    private TimerListener listener;
    private int MILLISECONDS_PER_SECONDS = 1000;

    /*       
	# Methods 
	# 	SetTimePeriod: set the amount of time the timer should be set for
	# 	RegisterTimerListener: register a TimerListener object
    #   Activate: activates the timer by calling listener.Notify
	*/
    public void SetTimePeriod(int seconds) {
        timerPeriod = seconds;
    }

    public void RegisterTimerListener(TimerListener listener) {
        this.listener = listener;
    }

    public void Activate() {
        Console.WriteLine("Activating timer...");
        
        Thread.Sleep(timerPeriod * MILLISECONDS_PER_SECONDS);
        listener.Notify();
    }
}