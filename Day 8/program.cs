Try catch:
               In C# programming, exception handling is performed by try/catch statement. The try block in C# is used to place the code that may 
               throw exception. The catch block is used to handled the exception. The catch block must be preceded by try block.
               
               
using System;  
public class ExceptionHandling  
{  
    public static void Main(string[] args)  
    {  
        try  
        {  
            int a = 10;  
            int b = 0;  
            int x = a / b;  
        }  
        catch (Exception e) { Console.WriteLine(e); }  
  
        
    }  
}                

Note: E in Exception should be capital ,if it's not capital ,then it'll give error.

___________________________________________________________________________________________________________________________________________________

Try ,catch and finally :C# finally block is used to execute important code which is to be executed whether exception is handled or not.


using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        try{
            int i =10;
            int j = 0;
            int z = i/j;
        }
        catch(Exception e){
            Console.WriteLine(e);
        }
        finally{
            Console.WriteLine("Finally block gets executed.");
        }
    }
}

__________________________________________________________________________________________________________________________________________________


Sealed : used to prevent inheritance .

using System;  
sealed public class Animal{  
    public void eat() { Console.WriteLine("eating..."); }  
}  
public class Dog: Animal  
{  
    public void bark() { Console.WriteLine("barking..."); }  
}  
public class TestSealed  
{  
    public static void Main()  
    {  
        Dog d = new Dog();  
        d.eat();  
        d.bark();  
  
  
    }  
}  
