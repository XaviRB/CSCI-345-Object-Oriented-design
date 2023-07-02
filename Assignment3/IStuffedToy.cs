/* 
# Author: Xavier Rodriguez        
# Description: IStuffedToy interface that has three abstract methods named Hug, Squeeze and Wash. Created a class named Bear and             
#              Bunny that derives from StuffedToy and implements the methods defined in the IStuffedToy interface blueprint.
# Date: 1/25/23          
# Specification: Interfaces and Runtime-Binding 
*/
interface IStuffedToy
{
     /*       
	# Methods 
	# 	Hug: Void so does not return anything or take any parameters.
	# 	Squeeze: Void so does not return anything or take any parameters.
    #   Wash: Void so does not return anything or take any parameters. 
	*/
    void Hug();
    void Squeeze();
    void Wash();
}

/*       
	# Description: Class named Bear and implements the interface methods defined in the IStuffedToy.
    #              simply output the name of the stuffed toy, the type of stuffed toy, and whether it’s being hugged, squeezed, or washed.              
    #              Bear class has one private field named name of type string. 
    #              This field represents the stuffed toy’s name. 
	# Parameters:
	# 	           String: name given as one of the parameters
	# Returns Value: A string from console.writeln and the string name assigned initially 	
	# Preconditions: A name string has been allocated.
	# Postconditions: Will call each method and will output what the stuffed toy is doing either hugged squeezed or washed
*/
class Bear : IStuffedToy {
    private String name;

    public Bear(String name) {
        this.name = name;
    }

    public void Hug() {
        Console.WriteLine(name + " is being hugged.");
    }

    public void Squeeze() {
        Console.WriteLine(name + " is being squeezed.");
    }

    public void Wash() {
        Console.WriteLine(name + " is being washed.");
    }
}
/*       
	# Description: Class named Bunny and implements the interface methods defined in the IStuffedToy.
    #              simply output the name of the stuffed toy, the type of stuffed toy, and whether it’s being hugged, squeezed, or washed.              
    #              Bear class has one private field named name of type string. 
    #              This field represents the stuffed toy’s name. 
	# Parameters:
	# 	           String: name given as one of the parameters
	# Returns Value: A string from console.writeln and the string name assigned initially 	
	# Preconditions: A name string has been allocated.
	# Postconditions: Will call each method and will output what the stuffed toy is doing either hugged squeezed or washed
*/
class Bunny : IStuffedToy {
    private String name;

    public Bunny(String name) {
        this.name = name;
    }

    public void Hug() {
        Console.WriteLine(name + " is being hugged.");
    }

    public void Squeeze() {
        Console.WriteLine(name + " is being squeezed.");
    }

    public void Wash() {
        Console.WriteLine(name + " is being washed.");
    }
    
}