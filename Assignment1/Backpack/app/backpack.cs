/* 
# Author: Xavier Rodriguez        
# Description: Backpack class that has all the atributes of adding/removing items to 
#              a backpack as well as returning a weight and telling if the item fits
#              in the backpack. 
# Date: 1/15/23          
# Specification: Class implementation file to model a backpack. 
*/

public class Backpack{
    /*       
	# Object Attributes 
	# 	mainPocketWeight: Represents the current weight in the main pocket.
	# 	leftPocketWeight: Represents the current weight in the left pocket.
    #   rightPocketWeight: Represents the current weight in the right pocket. 
	*/
    private double mainPocketWeight;
    private double leftPocketWeight;
    private double rightPocketWeight;
    

    /*       
	# Description: Method to InsertItemsInMainPocket and InsertItemsInLeftPocket and InsertItemsInRightPocket
    #              combines intial weight and the weight added on main, left and right pockets and returns a bool 
    #              if it is true or not if the weight can be added or not.
	# Parameters:
	# 	Double: Represents the weight . 
	# Returns Value: bool true or false			
	# Preconditions: A mainPocketWeight object has been allocated.
	# Postconditions: The mainPocketWeight, leftPocketWeight and rightPocketWeight object state represented 
    #                 by the pocketWeight field has been updated as well returns a true of false bool.
	*/
    public bool InsertItemsInMainPocket(double weight){
        double result = mainPocketWeight + weight;
        if(result <= 10){
            mainPocketWeight = result;
            return true;
        }
        else{
            return false;
        }
    }

    public bool InsertItemsInLeftPocket(double weight){
        double result = leftPocketWeight + weight;
        if(result <= 5){
            leftPocketWeight = result;
            return true;
        }
        else{
            return false;
        }
    }
    public bool InsertItemsInRightPocket(double weight){
        double result = rightPocketWeight + weight;
        if(result <= 5){
            rightPocketWeight = result;
            return true;
        }
        else{
            return false;
        }
    }

    /*       
	# Description: Method to GetTotalWeight of MainPocketWeight and LeftPocketWeight and RightPocketWeight
    #              combines intial weight and the weight added on main, left and right pockets and returns a bool 
    #              if it is true or not if the weight can be added or not.
	# Parameters: none 
	# Returns Value: Double 			
	# Preconditions: A mainPocketWeight, leftPocketWeight and rightPocketWeight object has been allocated.
	# Postconditions: The backpack object state represented by the PocketWeight field has been updated.
	*/
    public double GetTotalWeight(){
        double result = leftPocketWeight + rightPocketWeight + mainPocketWeight;
        return result;
    }

    /*       
	# Description: Method to RemoveItemsInMainPocket, RemoveItemsInLeftPocket and RemoveItemsInRightPocket
    #              removes the item weight either from the main, left or right pocket pockets and returns a bool 
    #              if it is true or not if the weight can be removed or not.
	# Parameters:
	# 	Double: Represents the weight . 
	# Returns Value: bool true or false			
	# Preconditions: A mainPocketWeight, rightPocketWeight and leftPocketWeight object has been allocated.
	# Postconditions: The mainPocketWeight, leftPocketWeight and rightPocketWeight object state represented 
    #                 by the pocketWeight field has been updated as well returns a true of false bool.
	*/
    public bool RemoveItemsFromMainPocket(double weight){
        
        if(weight <= mainPocketWeight){
            double result = mainPocketWeight - weight;
            mainPocketWeight = result;
            return true;
        }
        else{
            return false;
        }
    }

     public bool RemoveItemsFromRightPocket(double weight){
        
        if(weight <= rightPocketWeight){
            double result = rightPocketWeight - weight;
            rightPocketWeight = result;
            return true;
        }
        else{
            return false;
        }
    }

     public bool RemoveItemsFromLeftPocket(double weight){
        
        if(weight <= leftPocketWeight){
            double result = leftPocketWeight - weight;
            leftPocketWeight = result;
            return true;
        }
        else{
            return false;
        }
    }

}