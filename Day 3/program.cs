Continue Statement:

Problem Statement:To print the numbers from 1 to 10 by using for loop with continue statement 

using System;

public class Program
{
    public static void Main(string[] args)
    {
        for(int i = 1;i<=10 ;i++){
            if(i==6){
                continue;
            }
            Console.WriteLine(i);
        }
    }
}

_____________________________________________________________________________________________________________________________________________________________________

Goto Statement:

Problem statement: To check the person is eligible for voting or not by using goto statement.

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        ineligible:
        Console.WriteLine("since you're not 18 or above , you're ineligible to vote.");
        
        Console.WriteLine("Enter your age");
        int age = Convert.ToInt32(Console.ReadLine());
        
        if(age<18){
            goto ineligible;
        }
        else{
            Console.WriteLine("You're eligible to vote");
        }
    }
}

_____________________________________________________________________________________________________________________________________________________________________

Single Line Comment and Multi-Line Comment

//Write a program for addition 
//(THIS IS SINGLE LINE COMMENT)

/*Write a program for addition 
and take inputs from the user*/
/*THIS IS MULTI
LINE COMMENT*/
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter 1st number");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter 2nd number");
        int b = Convert.ToInt32(Console.ReadLine());
        
        int c= a+b;
        
        Console.WriteLine("Addition of the numbers you've entered is = " + c);
    }
}
