This Keyword:-

It can be used to refer current class instance variable. It is used if field names (instance variables) and parameter names are same, that is why both can be distinguish easily.
It can be used to pass current object as a parameter to another method.
It can be used to declare indexers.

using System;  
   public class Employee  
    {  
        public int id;   
        public String name;  
        public float salary;  
        public Employee(int id, String name,float salary)  
        {  
            this.id = id;  
            this.name = name;  
            this.salary = salary;  
        }  
        public void display()  
        {  
            Console.WriteLine(id + " " + name+" "+salary);  
        }  
   }  
   class TestEmployee{  
       public static void Main(string[] args)  
        {  
            Employee e1 = new Employee(101, "Sonoo", 890000f);  
            e1.display();  
        }  
    }  
    
    _____________________________________________________________________________________________________________________________________________________________________________________________
    
   structs:
   
    classes and structs are blueprints that are used to create instance of a class. Structs are used for lightweight objects such as Color, Rectangle, Point etc
    Unlike class, structs in C# are value type than reference type. It is useful if you have data that is not intended to be modified after creation of struct.
    
    
    using System;  
public struct Rectangle  
{  
    public int width, height;  
  
 }  
public class TestStructs  
{  
    public static void Main()  
    {  
        Rectangle r = new Rectangle();  
        r.width = 10;  
        r.height = 12;  
        Console.WriteLine("Area of Rectangle is: " + (r.width * r.height));  
    }  
}  

________________________________________________________________________________________________________________________________________________________________________________________________

Enum: are used to store constants like Days,Months.

The enum constants are also known as enumerators. Enum in C# can be declared within or outside class and structs.

Enum constants has default values which starts from 0 and incremented to one by one. But we can change the default value.

using System;  
public class EnumExample  
{  
    public enum Season { WINTER, SPRING, SUMMER, FALL }    
  
    public static void Main()  
    {  
        int x = (int)Season.WINTER;  
        int y = (int)Season.SUMMER;  
        Console.WriteLine("WINTER = {0}", x);  
        Console.WriteLine("SUMMER = {0}", y);  
    }  
}  

________________________________________________________________________________________________________________________________________________________________________________________________

