using System;
//TOPIC:     Design Patterns – Strategy Pattern – Animal with Flyable and Swimmable Behavior
//CLASS:     Animal, IFlyableBehavior and ISwimmableBehavior
class Program{
    static void Main(){
        // Initialize variables to store flyable and swimmable behaviors
        IFlyableBehavior flyable = null;
        ISwimmableBehavior swimmable = new SwimFast();
         // Create a horse object and call its methods
        Animal misty = new Horse("Misty", flyable, swimmable);
        misty.MakeSound();
        misty.Eat();
        misty.Swim();
        Console.WriteLine();
        // Create a hawk object and call its methods
        flyable = new FlyHigh();
        swimmable = null;
        Animal henry = new Hawk("Henry", flyable, swimmable);
        henry.MakeSound();
        henry.Eat();
        henry.Fly();
        Console.Read();
    }
}
