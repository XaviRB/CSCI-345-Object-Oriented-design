/* 
# Author: Xavier Rodriguez        
# Description: An abstract class CookieDecorator that uses ICookie interface and holds 
#              a reference to the cookie being decorated. Along with a constructor and a
#              method called Description to help decorate the cookie. Classes such as 
#              SprinklesCookieDecorator, FrostingCookieDecorator, ShortBreadCookie and
#              GingerBreadCookie are the classes that decorate the cookie based on what is called.
#              The program follows the Decorator Pattern.
# Date: 3/2/23             
# Specification: Design Patterns – Decorator Pattern – Cookie Decorator
*/
public abstract class CookieDecorator : ICookie{
    /*       
	# Fields 
	#   _cookie: The object that holds the cookie being decorated   	
	*/
    private readonly ICookie cookie;
    // Constructor that takes a cookie to decorate
    public CookieDecorator(ICookie _cookie){
        cookie = _cookie;
    }
    // Implementation of the Description method from the ICookie interface
    public virtual string Description(){
        return cookie.Description();
    }
}

/*       
# Description: A public class named SprinklesCookieDecorator/FrostingCookieDecorator that 
#              extends the CookieDecorator class and adds sprinkles/frosting to a cookie.
#              It does it by overriding the Description method to add sprinkles/frosting to the cookie's description.
# Parameters:
# 	           String: cookie
#              interfaces: ICookie
#              methods: Description         
# Returns Value: String
# Preconditions: ICookie interface and a method called Description 
# Postconditions: return a string with the cookie and either sprinkles or frosting.
*/
public class SprinklesCookieDecorator : CookieDecorator{
    public SprinklesCookieDecorator(ICookie cookie) : base(cookie){}

    public override string Description(){
        return $"{base.Description()} + sprinkles";
    }
}

public class FrostingCookieDecorator : CookieDecorator{
    public FrostingCookieDecorator(ICookie cookie) : base(cookie){}

    public override string Description(){
        return $"{base.Description()} + frosting";
    }
}

/*       
# Description: A public class named ShortBreadCookie/GingerBreadCookie that returns the description of the cookie 
# Parameters:
#              interface: ICookie
#              methods: Description       
# Returns Value: String
# Preconditions: That you have the interface calls and a method called Description
# Postconditions: Will return a string with the type of cookie so ShortBreadCookie or GingerBreadCookie
*/
public class ShortBreadCookie : ICookie{
    public string Description(){
        return "Shortbread cookie";
    }
}

public class GingerBreadCookie : ICookie{
    public string Description(){
        return "Gingerbread cookie";
    }
}