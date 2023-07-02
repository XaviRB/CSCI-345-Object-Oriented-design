/* 
# Author: Xavier Rodriguez        
# Description:  Abstract class named Animal that uses a class named Hawk/Horse. These classes inherits from Animal and implements the IFlyableBehavior 
#               interface and the ISwimmableBehavior interface. This is supposed to mimic an animal that would making sounds, eating, swiming or #               flying. Also have classes Flyhigh/low and SwimFast/Slow that will give a more specific behavior the animal will do. 
# Date: 2/21/23          
# Specification: Design Patterns – Strategy Pattern – Animal with Flyable and Swimmable Behavior
*/

abstract class Animal{
    /*       
	# Fields 
	# 	name: Protected string that contains the name
    #   IFlyableBehavior: protected field that store the animal flying behavior.
    #   ISwimmableBehavior: protected field that store the animal swimming behavior.
	*/
    protected string name;
    private IFlyableBehavior flyable;
    private ISwimmableBehavior swimmable;

    // Constructor that initializes the animal's name and behaviors.
    public Animal(string name, IFlyableBehavior flyableBehavior, ISwimmableBehavior swimmableBehavior) {
        this.name = name;
        this.flyable = flyableBehavior;
        this.swimmable = swimmableBehavior;
    }
    /*       
	# Methods 
	# 	Description: methods that will be implemented by derived classes
	# 	MakeSound: Makesound method that will emulate a animal sound
    #   Eat: Eat method that will emulate it eating
    #   Swim: delegates swimming behavior to the ISwimmableBehavior object
    #   Fly: delegates flying behavior to the IFlyableBehavior object
	*/
    public abstract void Eat();
    
    public void Fly() {
        flyable.Fly();
    }

    public abstract void MakeSound();

    public void Swim() {
        swimmable.Swim();
    }
}

/*       
# Description: Class named Horse that derives from Animal and implements ISwimmableBehavior and IFlyableBehavior
#              as well as uses the methods Eat and MakeSound
# Parameters:
# 	           String: name
#              interfaces: IFlyableBehavior and ISwimmableBehavior
#              methods: Horse, eat, makesound            
# Returns Value: String
# Preconditions: That you have the interface calls and a string name
# Postconditions: Will return a string with the animal type and happens when it eats/make sound and swims
*/
class Horse : Animal{
    public Horse(string name, IFlyableBehavior flyableBehavior, ISwimmableBehavior swimmableBehavior)
        : base(name, flyableBehavior, swimmableBehavior) { }

    public override void Eat() {
        Console.WriteLine($"{name} the horse is eating.");
    }

    public override void MakeSound() {
        Console.WriteLine($"{name} the horse is neighing.");
    }

}

/*       
# Description: Class named Hawk that derives from Animal and implements ISwimmableBehavior and IFlyableBehavior
#              as well as uses the methods Eat and MakeSound
# Parameters:
# 	           String: name
#              interfaces: IFlyableBehavior and ISwimmableBehavior
#              methods: Hawk, eat, makesound             
# Returns Value: String
# Preconditions: That you have the interface calls a string name
# Postconditions: Will return a string with the animal type and happens when it eats/make sound and flys
*/
class Hawk : Animal{
    public Hawk(string name, IFlyableBehavior flyableBehavior, ISwimmableBehavior swimmableBehavior)
        : base(name, flyableBehavior, swimmableBehavior) { }

    public override void Eat() {
        Console.WriteLine($"{name} the hawk is eating.");
    }

    public override void MakeSound() {
        Console.WriteLine($"{name} the hawk is screeching.");
    }
}

/*       
# classes 
# 	Description: classes that call a method that will represents a behavior of the object/anmial 
#   FlyHigh: Class that represents a behavior where an object can fly high 	
#   FlyLow: Class that represents a behavior where an object can fly low   
#   SwimFast: Class that represents a behavior where an object can swim fast
#   SwimSlow: Class that represents a behavior where an object can swim slow
*/
public class FlyHigh : IFlyableBehavior{
    public void Fly(){
        Console.WriteLine("Henry Flying high");
    }
}

public class FlyLow : IFlyableBehavior{
    public void Fly(){
        Console.WriteLine("Henry Flying low");
    }
}

public class SwimFast : ISwimmableBehavior{
    public void Swim(){
        Console.WriteLine("Misty Swimming fast");
    }
}

public class SwimSlow : ISwimmableBehavior{
    public void Swim(){
        Console.WriteLine("Misty Swimming slow");
    }
}