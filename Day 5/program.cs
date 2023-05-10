List:C# List<T> class is used to store and fetch elements. It can have duplicate elements. To use List we will use System.Collections.Generic namespace.

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var cities = new List<string>();
        cities.Add("Pune");
        cities.Add("Mumbai");
        cities.Add("Delhi");
        cities.Add("Bangalore");
        
        foreach (var city in cities){
            Console.WriteLine(city);
        }
    }
}

___________________________________________________________________________________________________________________________________________________________________________________

Hashset : Hashset is used to store unique elements and its also the part of System.Collections.Generic namespace. It simply ignores the same element without giving error.

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var cities = new HashSet<string>();
        cities.Add("Pune");
        cities.Add("Mumbai");
        cities.Add("Delhi");
        cities.Add("Bangalore");
        cities.Add("Pune");
        
        foreach (var city in cities){
            Console.WriteLine(city);
        }
    }
}

_______________________________________________________________________________________________________________________________________________________________________________

SortedSet: Sorted is just like HashSet i.e, it does not store duplicate elements but additionaly it also It maintains ascending order.

using System;
using System.Collections.Generic;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        var cities = new SortedSet<string>();
        cities.Add("Pune");
        cities.Add("Mumbai");
        cities.Add("Delhi");
        cities.Add("Bangalore");
        cities.Add("Pune");
        
        foreach (var city in cities){
            Console.WriteLine(city);
        }
    }
}

