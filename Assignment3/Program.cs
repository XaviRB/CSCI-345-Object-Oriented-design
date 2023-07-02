//TOPIC:     Interfaces and Runtime-Binding
//CLASS:     IStuffedToy
class Program
{
static void Main(string[] args)
      {
        //Initalizing a new list named stuffedToy
        List<IStuffedToy> stuffedToys = new List<IStuffedToy>();
        //Initalizing the name of the StuffedToy and if it is a bear or bunny
        IStuffedToy bear = new Bear("Teddy");
        IStuffedToy bunny = new Bunny("Bugs");

        //Adding each name given to either bear or bunny
        stuffedToys.Add(bear);
        stuffedToys.Add(bunny);
        //Running through the list of methods to call for the list of StuffedToy
        ProcessStuffedToys(stuffedToys);
        Console.ReadLine();        
    }
    // ProceessStuffedToys method that receives an array of objects that implement the 
    // IStuffedToy interface. Calls each method in the IStuffedToy 
    // interface for each array element object Hug, Squeeze and Wash. 
    static void ProcessStuffedToys(List<IStuffedToy> stuffedToys) {
        foreach (IStuffedToy stuffedToy in stuffedToys) {
            stuffedToy.Hug();
            stuffedToy.Squeeze();
            stuffedToy.Wash();
        }
    }

}
