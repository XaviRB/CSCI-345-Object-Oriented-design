using System;
//TOPIC:     Class Inheritance, Abstract Base Classes, and Interfaces
//CLASS:     Animal, IFlyable and ISwimable 
class Program{
    static void Main(){
        // Create an instance of Horse named Misty
        Animal misty = new Horse("Misty");
        misty.MakeSound();
        misty.Eat();
        // Create an instance of Hawk named Henry
        Animal henry = new Hawk("Henry");
        henry.MakeSound();
        henry.Eat();
        // Cast the instance of Horse as an ISwimable and call Swim
        ISwimable swimmer = (ISwimable)misty;
        swimmer.Swim();
        // Cast the instance of Hawk as an IFlyable and call Fly
        IFlyable flyer = (IFlyable)henry;
        flyer.Fly();

        Console.Read();
    }
}