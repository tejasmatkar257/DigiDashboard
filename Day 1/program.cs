if else :

Problem Statement:To check whether the number is positive or negative number.  

Public class Program
  {
     public static void Main(String[] args)
       {
           Console.WriteLine("Enter any number to check whether it it positive or negative number.");
           int a = Convert.ToInt32(Console.ReadLine());
           if(a == 0 )
              {
                 Console.WriteLine("You've entered a zero.");
              }
           else if(a > 0)
              {
                 Console.WriteLine("The number you've entered is a positive number");
              }
           else
              {
                 Console.WriteLine("The number you've entered is a negative number");");
              }
           
       }
  }
  
____________________________________________________________________________________________________________________________________________________________________  
    
Switch:

Program Statement: To Check whether entered alphabet is a vowel or consonant.

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter any alphabet to check whether is it vowel or consonant");
        char ch = Convert.ToChar(Console.ReadLine());
         switch(ch){
            case 'a':
            case 'A':
            case 'e':
            case 'E':
            case 'i':
            case 'I':
            case 'o':
            case 'O':
            case 'u':
            case 'U':
            Console.WriteLine("The alphabet you've entered is a vowel");break;
            default:Console.WriteLine("The alphabet you've entered is a consonent");break;
        }
    }
}


_______________________________________________________________________________________________________________________________________________________________________

For Loop:

Program Statement:To print the number from 0 to 6.

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        for(int i = 0 ; i<=6 ; i++){
            Console.WriteLine(i);
        }
    }
}
  
