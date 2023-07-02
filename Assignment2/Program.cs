using System;
//TOPIC:     Class Inheritance, Abstract Base Classes, and Runtime-Binding 
//CLASS:     StuffedToy
public class Program
{
static void Main(string[] args) {

    List<StuffedToy> stuffedToys = new List<StuffedToy>();

    //For loop going through each call of stuffed toy and calling the hug, squeeze and wash method
    static void ProcessStuffedToys(List<StuffedToy> stuffedToys){
        foreach (StuffedToy toy in stuffedToys){
            toy.Hug();
            toy.Squeeze();
            toy.Wash();
        }
    }

    //Initalizing the name of the StuffedToy and if it is a bear or bunny
    StuffedToy bear = new Bear("Teddy");
    StuffedToy bunny = new Bunny("Bugs");

    //Adding each name given to either bear or bunny
    stuffedToys.Add(bear);
    stuffedToys.Add(bunny);
    
    //Running through the list of methods to call for the list of StuffedToy
    ProcessStuffedToys(stuffedToys);

    Console.ReadLine();
    }
}