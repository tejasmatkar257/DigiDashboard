Array :Like other programming languages, array in C# is a group of similar types of elements that have contiguous memory location. In C#, array is an object of base type 
System.Array. In C#, array index starts from 0. We can store only fixed set of elements in C# array.

1.C# Single Dimensional Array

using System;

public class ArrayExample{
    public static void Main(string[]args){
        int[] arr = new int[5];
        arr[0] = 1;
        arr[2] =2 ;
        arr[3] = 4;
        
        for(int i=0;i< arr.Length ;i++){
            Console.WriteLine(arr[i]);
        }
    }
}

___________________________________________________________________________________________________________________________________________________________________________

2. Declaration and Initialization at same time

using System;

public class ArrayExample{
    public static void Main(string[]args){
        int[] arr = {1,2,3,4,5};
        
        for(int i=0;i< arr.Length ;i++){
            Console.WriteLine(arr[i]);
        }
    }
}

_____________________________________________________________________________________________________________________________________________________________________________

3.by using foreach loop

using System;

public class ArrayExample{
    public static void Main(string[]args){
        int[] arr = {1,2,3,4,5};
        
        foreach(int i in arr){
            Console.WriteLine(i);
        }
    }
}
