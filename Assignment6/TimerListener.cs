//My Listener class
class TimerListener{
    // private field stores listener name
    private string name;

    //Constructor
    public TimerListener(string listenerName){
        name = listenerName;
    }

    //Notify method that sends the message to console
    public void Notify(){
        Console.WriteLine(name + ", wake up!");
    }
}