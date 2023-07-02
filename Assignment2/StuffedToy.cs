/* 
# Author: Xavier Rodriguez        
# Description: StuffedToy abstract class that has three abstract methods named Hug, Squeeze and Wash. Created a class named Bear and             
#              Bunny that derives from StuffedToy and implements the abstract methods defined in the StuffedToy abstract class.
# Date: 1/18/23          
# Specification: Class Inheritance, Abstract Base Classes, and Runtime-Binding. 
*/
abstract class StuffedToy
{
     /*       
	# Abstract Methods 
	# 	Hug: Represents the current weight in the main pocket.
	# 	Squeeze: Represents the current weight in the left pocket.
    #   Wash: Represents the current weight in the right pocket. 
	*/
   protected string name;

    public StuffedToy(string name)
    {
        this.name = name;
    }

    public abstract void Hug();
    public abstract void Squeeze();
    public abstract void Wash();
}

/*       
	# Description: Class named bear and implements the abstract methods defined in the StuffedToy class.
    #              simply output the name of the stuffed toy, the type of stuffed toy, and whether it’s being hugged, squeezed, or washed.              
    #              Constructor that calls the base class constructor to initialize the name field.
	# Parameters:
	# 	           String: name given as one of the parameters
	# Returns Value: A string from console.writeln 	
	# Preconditions: A name string has been allocated.
	# Postconditions: Will override the call of each method and will outut what the stuffed toy is doing either hugged squeezed or washed
*/
class Bear : StuffedToy
{
    public Bear(string name) : base(name) { }

    public override void Hug()
    {
        Console.WriteLine(name + " the Bear is being hugged.");
    }

    public override void Squeeze()
    {
        Console.WriteLine(name + " the Bear is being squeezed.");
    }

    public override void Wash()
    {
        Console.WriteLine(name + " the Bear is being washed.");
    }
}
/*       
	# Description: Class named bunny and implements the abstract methods defined in the StuffedToy class.
    #              simply output the name of the stuffed toy, the type of stuffed toy, and whether it’s being hugged, squeezed, or washed.              
    #              Constructor that calls the base class constructor to initialize the name field.
	# Parameters:
	# 	           String: name given as one of the parameters
	# Returns Value: A string from console.writeln 	
	# Preconditions: A name string has been allocated.
	# Postconditions: Will override the call of each method and will outut what the stuffed toy is doing either hugged squeezed or washed
*/
class Bunny : StuffedToy
{
    public Bunny(string name) : base(name) { }

    public override void Hug()
    {
        Console.WriteLine(name + " the Bear is being hugged.");
    }

    public override void Squeeze()
    {
        Console.WriteLine(name + " the Bear is being squeezed.");
    }

    public override void Wash()
    {
        Console.WriteLine(name + " the Bear is being washed.");
    }
    
}