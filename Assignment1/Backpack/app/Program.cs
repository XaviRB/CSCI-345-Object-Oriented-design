using System;
//TOPIC:     Classes, Objects and Dynamic Memory Allocation 
//CLASS:     backpack
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Running the Backpack application...");

        //initalzing backpack field
        Backpack backpack = new Backpack();


        //Calling InsertItemsInMainPocket, InsertItemsInLeftPocket and InsertItemsInRightPocket
        //and console out the result each mehtod call.
        bool result = backpack.InsertItemsInMainPocket(4);

        if (result == true)
        {
            Console.WriteLine("Item inserted in main pocket...");
        }
        else
        {
            Console.WriteLine("Item could not be inserted in main pocket...");
        }

        result = backpack.InsertItemsInRightPocket(4);

        if (result == true)
        {
            Console.WriteLine("Item inserted in right pocket...");
        }
        else
        {
            Console.WriteLine("Item could not be inserted in right pocket...");
        }

        result = backpack.InsertItemsInLeftPocket(4);

        if (result == true)
        {
            Console.WriteLine("Item inserted in left pocket...");
        }
        else
        {
            Console.WriteLine("Item could not be inserted in left pocket...");
        }

        //Calling the Total weight and consoling out the result
        double backPackTotalWeight = backpack.GetTotalWeight();
        Console.WriteLine("Backpack total weight: " + backPackTotalWeight);
        Console.WriteLine("");

        //Calling RemoveItemsInMainPocket, RemoveItemsInLeftPocket and RemoveItemsInRightPocket
        //and console out the result each mehtod call.
        result = backpack.RemoveItemsFromMainPocket(1);

        if (result == true)
        {
            Console.WriteLine("Item Removed in main pocket...");
        }
        else
        {
            Console.WriteLine("Item could not be Removed in main pocket...");
        }

        result = backpack.RemoveItemsFromRightPocket(1);

        if (result == true)
        {
            Console.WriteLine("Item Removed in right pocket...");
        }
        else
        {
            Console.WriteLine("Item could not be Removed in right pocket...");
        }

        result = backpack.RemoveItemsFromLeftPocket(5);

        if (result == true)
        {
            Console.WriteLine("Item Removed in left pocket...");
        }
        else
        {
            Console.WriteLine("Item could not be Removed in left pocket...");
        }

        //Checking the removed weight
        backPackTotalWeight = backpack.GetTotalWeight();
        Console.WriteLine("Backpack total weight: " + backPackTotalWeight);

    }
}