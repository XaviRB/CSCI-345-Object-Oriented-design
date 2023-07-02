/* 
# Author: Xavier Rodriguez        
# Description: Abstract class Appliance that serves as a base class for appliances such as Fridge, Dishwasher, and Oven. 
#              That returns the description and the state of the appliance if it is off or on. 
# Date: 2/2/23          
# Specification: Class Inheritance, Abstract Base Classes, and Runtime-Binding
*/
abstract class Appliance
{
    /*       
	# Fields 
	# 	make: stores the make of the appliance
	# 	state: stores the current state (on or off) of the appliance
	*/
    protected string make;
    protected ApplianceState state;

    /*       
	# Constructor 
	# 	make: Takes in the make of the appliance and sets the state to off (default state is off). 
	*/
    public Appliance(string make)
    {
        this.make = make;
        state = ApplianceState.Off;
    }
    
    /*       
	# Methods 
	# 	Description: returns the type make and state of the Appliance
	# 	TurnOff: Turns state off
    #   TurnOff: Turns state on
	*/
    public virtual string Description()
    {
        return $"This is a {this.GetType().Name} made by {make}, current state is {state}.";
    }
    public abstract void TurnOff();
    public abstract void TurnOn();
}

/*       
    # Description: Class named Fridge/Dishwasher/Oven that implements Appliance also has a constructor to call the base constructor 
    #              and set the make. Then Two methods named TurnedOn and TurnOff that changes the state of the appliance.
	# Parameters:
	# 	           String: make and base.
	# Returns Value: state.	
	# Preconditions: A make string has been allocated.
	# Postconditions: Will update the the state of the appliance so when it is called in description the proper output is there.
*/
class Fridge : Appliance
{
    public Fridge(string make) : base(make) { }

    public override void TurnOn()
    {
        state = ApplianceState.On;
    }

    public override void TurnOff()
    {
        state = ApplianceState.Off;
    }
    
    
}

class Dishwasher : Appliance
{
    public Dishwasher(string make) : base(make) { }


    public override void TurnOn()
    {
        state = ApplianceState.On;
    }

    public override void TurnOff()
    {
        state = ApplianceState.Off;
    }
    
}

class Oven : Appliance
{
    public Oven(string make) : base(make) { }


    public override void TurnOn()
    {
        state = ApplianceState.On;
    }

    public override void TurnOff()
    {
        state = ApplianceState.Off;
    }
    
}