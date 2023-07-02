using System;
using System.Collections.Generic;
//TOPIC:     Class Inheritance, Abstract Base Classes, and Runtime-Binding
//CLASS:     Appliance and ApplianceState
class Program
{
    static void Main(string[] args)
    {
        List<Appliance> appliances = new List<Appliance>();
        //Input
        Appliance maytag = new Fridge("Maytag");
        Appliance amana = new Oven("Amana");
        Appliance kitchenAid = new Dishwasher("Kitchen Aid");
        Appliance whirlpool = new Dishwasher("Whirlpool");
        appliances.Add(maytag);
        appliances.Add(amana);
        appliances.Add(kitchenAid);
        appliances.Add(whirlpool);
        //Process & Output
        DescribeYourselves(appliances);
        TurnOnAppliances(appliances);
        DescribeYourselves(appliances);
        TurnOffAppliances(appliances);
        DescribeYourselves(appliances);
        Console.ReadLine();
    }
    //Calls a description for each appliance
    public static void DescribeYourselves(List<Appliance> appliances)
    {
        foreach (Appliance appliance in appliances)
        {
            Console.WriteLine(appliance.Description());
        }
        Console.WriteLine();
    }
    //Calls TurnOn for each appliance and changes each state to on
    public static void TurnOnAppliances(List<Appliance> appliances)
    {
        foreach (Appliance appliance in appliances)
        {
            appliance.TurnOn();
        }
        Console.WriteLine();
    }
    //Calls TurnOn for each appliance and changes each state to off
    public static void TurnOffAppliances(List<Appliance> appliances)
    {
        foreach (Appliance appliance in appliances)
        {
            appliance.TurnOff();
        }
        Console.WriteLine();
    }
}   