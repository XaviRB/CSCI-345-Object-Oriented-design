using System;
//TOPIC:     Design Patterns – Decorator Pattern – Cookie Decorator
//CLASSES:   Animal, IFlyableBehavior and ISwimmableBehavior
public class Program
{
    public static void Main(string[] args)
    {
        ICookie gingerBreadCookie = new GingerBreadCookie();
        ICookie shortBreadCookie = new ShortBreadCookie();
        //Decorate Gingerbread Cookie with Sprinkles
        CookieDecorator gingerBreadSprinklesDecorator = new 
        SprinklesCookieDecorator(gingerBreadCookie);
        //Decorate Shortbread Cookie with Sprinkles and Frosting
        CookieDecorator shortBreadSprinklesDecorator = new 
        SprinklesCookieDecorator(shortBreadCookie);
        shortBreadSprinklesDecorator = new 
        FrostingCookieDecorator(shortBreadSprinklesDecorator);
        
        Console.WriteLine(gingerBreadSprinklesDecorator.Description());
        
        Console.WriteLine();
        Console.WriteLine(shortBreadSprinklesDecorator.Description());
        Console.ReadLine();
    }
}