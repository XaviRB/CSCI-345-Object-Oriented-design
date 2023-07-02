/* 
# Author: Xavier Rodriguez        
# Description:  Abstract class named Animal that uses a class named Hawk/Horse. These classes inherits from Animal and implements the IFlyable                          #               interface and the ISwimable interface. This is supposed to mimic an animal that would making sounds, eating, swiming or flying.   
# Date: 2/9/23          
# Specification: Class Inheritance, Abstract Base Classes, and Interfaces
*/

abstract class Animal{
    /*       
	# Fields 
	# 	name: Protected string that contains the name
	*/
    protected string name;
    //constructor
    public Animal(string name){
        this.name = name;
    }
    /*       
	# Methods 
	# 	Description: Abstract methods that will be implemented by derived classes
	# 	MakeSound: Makesound method that will emulate a animal sound
    #   Eat: Eat method that will emulate it eating
	*/
    public abstract void MakeSound();
    public abstract void Eat();
}

/*       
    # Description: Class named Horse that derives from Animal and implements ISwimable
	# Parameters:
	# 	           String: name
    #              interface: Swimable
    #              methods: eat, makesound            
	# Returns Value: String
	# Preconditions: That you have an interface and a string name
	# Postconditions: Will return a string with the animal type and happens when it eats/make sound and swims
*/
class Horse : Animal, ISwimable{
    public Horse(string name) : base(name){}

    public override void MakeSound(){
        Console.WriteLine("Horse " + name + " says: Neigh");
    }

    public override void Eat(){
        Console.WriteLine("Horse " + name + " eats hay");
    }

    public void Swim(){
        Console.WriteLine("Horse " + name + " swims in the lake");
    }
}
/*       
    # Description: Class named Hawk that derives from Animal and implements ISwimable
	# Parameters:
	# 	           String: name
    #              interface: flyable
     #             methods: eat, makesound            
	# Returns Value: String
	# Preconditions: That you have an interface and a string name
	# Postconditions: Will return a string with the animal type and happens when it eats/make sound and flys
*/
class Hawk : Animal, IFlyable{
    public Hawk(string name) : base(name){}

    public override void MakeSound(){
        Console.WriteLine("Hawk " + name + " Screechs");
    }

    public override void Eat(){
        Console.WriteLine("Hawk " + name + " eats mice");
    }

    public void Fly(){
        Console.WriteLine("Hawk " + name + " flies in the sky");
    }
}