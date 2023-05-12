Constructor:constructor is a special type of method which is invoked automatically during the time of object creation.It is used to initialize the data members of new object 
generally.

There are two types of constructor : 1.Default Constructor
                                     2.Parameterized Constructor 

1.Default onstructor:

using System;

public class Employee
{
    public Employee(){
        Console.WriteLine("Constructor invoked automatically");
    }

    public static void Main(string[] args)
    {
        
        Employee e1 = new Employee();
        
    }
}

______________________________________________________________________________________________________________________________________________________________________________

2. Parameterized Constructor :A constructor which has parameters is called parameterized constructor. It is used to provide different values to distinct objects.

using System;

public class Employee
{
    public int id;
    public string name;
    public float salary;
    
    public Employee(int i,string n,float s){
        id=i;
        name=n;
        salary=s;
    }
    
    public void display(){
        Console.WriteLine(id + " " + name + " " + salary);
    }

    public static void Main(string[] args)
    {
        
        Employee e1 = new Employee(101,"Virat",1500000);
        e1.display();
        
    }
}

____________________________________________________________________________________________________________________________________________________________________________

Destructor:- Destructor is also invoked automatically while object creation.But it completely destructs the object.
Destructor is denoted by Tilde(~) Symbol.
We Don't use access specifier before destructor .

Syntax  ~Destructor_name

using System;

public class Employee
{
    ~Employee(){
        Console.WriteLine("Destructor invoked automatically");
    }
    public Employee(){
        Console.WriteLine("Constructor invoked automatically");
    }

    public static void Main(string[] args)
    {
        
        Employee e1 = new Employee();
        
    }
}

Even here we've typed destructor first ,but constructor going to compile first.

