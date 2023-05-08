While Loop:

Problem Statement:To print numbers from 1 to 10 using while loop

using System;

public class Program
{
    public static void Main(string[] args)
    {
        int i = 1;
        while(i<=10)
        {
            Console.WriteLine (i);
            i++;
        }
    }
}

_______________________________________________________________________________________________________________________________________________________________________

Do While Loop:

using System;

Problem Statement:To print numbers from 1 to 10 using do while loop

public class Program
{
    public static void Main(string[] args)
    {
        int i=1;
        do
        {
            Console.WriteLine (i);
            i++;
        }
            while(i<=10);
    }
}

_______________________________________________________________________________________________________________________________________________________________________

Break Statement:

Problem Statement:To print numbers 1 to 5 using for loop and break statement.

using System;

public class Program
{
    public static void Main(string[] args)
    {
        for(int i = 1;i<=10 ;i++){
            if(i==6){
                break;
            }
            Console.WriteLine(i);
        }
    }
}
