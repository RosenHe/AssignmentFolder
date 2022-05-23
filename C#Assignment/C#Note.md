```diff
+ Green
- Red
! Orange
@@ Pink @@
# Gray
```

<h1>Delegate</h1>

```diff
! Definition
A reference type variable that holds a referenece to a method/function via specific parameter list and return type.
    - It is like using delegate to handle function event();
    - Function Pointer.

    By using += sign, One delegate can call multiple methods.
!  Where to Use
    - Callback and asychronous implementation. 
    - Event Handling.
! Advantage
    - Provide better output and enhance the performance of the application.
! Disadvantage

```
<h1>Anonymous, Lamda, Action, Prediction and Func</h1>
<h4>Anonymous Definition</h4>
A class without any name that can contain public read-only properties only

```
var student = new { Id = 1, FirstName = "James", LastName = "Bond" };
//Can't change the values of properties as they are read-only.
```
<h4>Advantage</h4>
In saving memory and unnecessary code.

<h4>Anonymous Method</h4>
When user wants to create an inline method and also wants to pass parameter in the anonymous method like other methods.

```
//Anonymous in LinQ
class Geeks {
  
    public int A_no;
    public string Aname;
    public string language;
    public int age;
}
  
class GFG {
    // Main method
    static void Main()
    {
        List<Geeks> g = new List<Geeks> 
        {
  
            new Geeks{ A_no = 123, Aname = "Shilpa",
                        language = "C#", age = 23 }
        };
  
        // select query showing result
        // using anonymous type
        var anony_ob = from geek in g select new {geek.A_no, geek.Aname, geek.language};
    }
}
```
<h4>Lamda Operation</h4>
Lamda operation is used to create an anonymous method, It uses delegate to create an anonymouse methods. 

```
List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };  
List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);  
```
<h5>Advantage</h5>
Enhanced Iterative Syntax.
Simplified variable scope.
When doing Leetcode. Sometime we use lamda express to make a maxium queue.

```
//This is Java. Not sure about C#
PriorityQueue<Integer> maxPQ = new PriorityQueue<>((a,b) -> b - a); 
```
<h4>Action delegate</h4>
Action takes zero, one or more input parameters, but does not return anything.

```
private static int result;  
       static void Main(string[] args)  
       {  
           Action<int, int> Addition = delegate (int param1, int param2)  
           {  
               result = param1 + param2;  
           };  
           Addition(10, 20);  
           Console.WriteLine($"Addition = {result}");  
       } 
```
<h4>Func delegate</h4>
Func delegate takes zero, one or more input parameters, and return a value(with its out parameter).

```
public delegate TResult Func<in T1, in T2, out TResult>(T1 arg, T2 arg2) 
```
<h4>Predicate delegate</h4>
Predicate is a special kind of Func, It represents a method that contains a set of criteria mostly defined inside an if condition and checks whether the passed parameter meets those criteria or not.
You don't specify a return type because it is always a bool.

```
Predicate < string > CheckIfApple = delegate(string modelName) {  
    if (modelName == "I Phone X") return true;  
    else return false;  
};  
bool result = CheckIfApple("I Phone X");  
if (result) Console.WriteLine("It's an IPhone");   
```

<h1>Properties</h1>

<h4> Definition</h4>
An abstraction to get and set their values
<h4> How to use</h4>
When making Entity.

<h1>Field</h1>
<h4> Definition</h4>
An Ordinary member variables or member instances of a class.
<h4> How to use</h4> 

```diff
 public class DepartmentRepository : IRepository<Departments>
    {
        List<Departments> _list; @@This is Field@@(I guess)
        public DepartmentRepository()
        {
            _list = new List<Departments>();
        }
    }
```

<h1>Static</h1>
It makes the variable to retain its value between multiple function calls.
Used with global variables and functions to set their scope to the containing file.
If multiple instances of a class are created, the last updated value of a static member will be available to all instances.
一个class有一个memberNumber field。 这个就可以弄成static。这样子每次create 一个class。 这个membernumber++。

```
public class Employee4
{
    public string id;
    public string name;

    public Employee4()
    {
    }

    public Employee4(string name, string id)
    {
        this.name = name;
        this.id = id;
    }

    public static int employeeCounter;

    public static int AddEmployee()
    {
        return ++employeeCounter;
    }
}

```

<h1>Const & Readonly</h1>
Generally, readonly means only that you can't re-assign a field outside the constructor. 
<table border="0">
 <tr>
    <td><b style="font-size:15px">Const</b></td>
    <td><b style="font-size:15px">Readonly</b></td>
 </tr>
 <tr>
    <td>Immutable, complie time constant.</td>
    <td>Immutable, runtime constant</td>
 </tr>
  <tr>
    <td>only assign values in declaration part.</td>
    <td>Assign values in declaration and in the constructor part.</td>
 </tr>
   <tr>
    <td>cannot be used with static </td>
    <td>can used with static modifiers.</td>
 </tr>
  <tr>
    <td>ClassName.VariableName</td>
    <td>InstanceName.VariableName</td>
 </tr>
</table>

```
using System;
 
class GFG {
 
    // readonly variables
    public readonly int myvar1;
    public readonly int myvar2;
    //Constant fields
    public const string str = "I am const field."
 
    // Values of the readonly
    // variables are assigned
    // Using constructor
    public GFG(int b, int c)
    {
 
        myvar1 = b;
        myvar2 = c;
        Console.WriteLine("Display value of myvar1 {0}, "+
                        "and myvar2 {1}", myvar1, myvar2);
    }
 
    // Main method
    static public void Main()
    {
        GFG obj1 = new GFG(100, 200);
    }
}
```

<h1>Partial</h1>

```
1. You can split the The UI of the design code and the business logic code to read and understand the code. 
2. Maintain application in an eddicient manner by compressing large classes into small ones. 
3. Multiple developers can work simultaneously in the same class in different files.
```
<h1>Value type & Reference type</h1>
Value type: holds the data within own memory allocation.

<h4>Reference Type</h4>
Reference type: contains a pointer to another memory location that holds the real data.
Reference Type variables are stored in a different area of memory called the heap. This means that when a reference type variable is no longer used, it can be marked for garbage collection.

<h1>Grabage Collection</h1>
garbage collection is very useful as it automatically releases the memory space after it is no longer required. 

<h1>Class & Struct</h1>
<table border="0">
 <tr>
    <td><b style="font-size:15px">Class</b></td>
    <td><b style="font-size:15px">Struct</b></td>
 </tr>
 <tr>
    <td>Private members (By default).</td>
    <td>Public members (By default).</td>
 </tr>
  <tr>
    <td>reference type data type</td>
    <td>value type data type</td>
 </tr>
   <tr>
    <td>support inheritance</td>
    <td>No</td>
 </tr>
   <tr>
    <td>reference can be null</td>
    <td>No null</td>
 </tr>
</table>

<h4>In this way, struct should be used only when you are sure that,</h4>

```
It logically represents a single value, like primitive types (int, double, etc.).
It is immutable.
It should not be boxed and un-boxed frequently.
```
<h1>Value Type & Reference Type & Pointer Type</h1>

```
Value type:  directly store the variable value in memory, Like Int. Boolean. Double. Char.
Reference Type: contain a memory address of variable value because the reference type won't store the variable directly in memory. String. Object.
Pointer Type: contain a memory address of the variable value.
```
<h1>Boxed & Un-boxed</h1>
Basically it is value type convert to reference type, and vice versa. 

```diff
int num = 10;
Object obj = num; // Boxing
int i = (int)obj; //Unboxing
- So Avoid Boxing and unboxing when not necessary, use generics collections.
- Make the value type simple.
- Or you have to use object. unless you have to cast it,
Source: https://stackoverflow.com/questions/1028520/use-cases-for-boxing-a-value-type-in-c
```


<h1>Overloading & Override</h1>

```diff
overloading: @@ Same function name, different parameter @@
overriding: @@ Rewrite parent's function. @@
Overloading occurs when two or more methods in one class have the same method name but different parameters. Overriding occurs when two methods have the same method name and parameters. One of the methods is in the parent class, and the other is in the child class.
```

<h1> How do you make a method parameter optional?</h1>

```
1. By using default value.
2. By using method overloading.
3. By using Optinal Arrtribute.
```

<h1>What is an interface and how is it different from abstract class?</h1>

```
An abstract class allows you to create functionality that subclasses can implement or override.
An interface only allows you to define functionality, not implement it.
Whereas a class can extend only one abstract class, it can take advantage of multiple interfaces.
```
<h1>Virtual Method & Abstraction Method</h1>
Used virtual method to implement the ploymorphism feature.
Virtual Method have an implementation and provide the derived classes with the options of overrriding it.
Abstraction Method do not have implementation. require derived classes to override the method.

<h3>The purpose of an abstract class is to provide a common definition of a base class that multiple derived classes can share.</h3>

<h1>Tuple</h1>
Tuple, maximum 8, can store any type. < T1,T2, T3..T8 >

<h1>Record</h1>
Sometimes we have a class defined. but we need to update(add) new property. we have to modify the class, reassign and update. 
By using "With" expression, we can define new values for a specific property.

To define a @@ reference @@ type that provides built-in functionality for encapsulationg data.


```
var member = new Member
{
    Id=1,
    FirstName="Kirtesh",
    LastName="Shah",
    Address = "Vadodara"
};

var newMember = member with { Address = "Mumbai" };
```

<h1>What does constructor do in a class? Can it be overridden? Can it be overloaded?</h1>
Creating obejct of the Class that it is by initializing all the instance variables and creating a place in memory to hold the object. no overridden. Okay with overloaded.

<h1>Explain different access modifiers in C# </h1>

```diff
+ Public 大家玩
    Accessible from everywhere in a project without any restrictions.
+ Private 自己玩
    Accessible only inside a class or a structure.
+ Protected 此程序的自己和child class， 别的程序的derived clas
    Accessible inside the class and in all classes that derive from the class.
+ Internal 此程序的all classes，same assembly
    Limited exclusively to classes defined within the current project assembly
+ Protected Internal 此程序的all clases。 和别的程序derived class
    A combination of protected and internal.
    The proected internal member only in the same assembly or in a derived class in other assemblies.
+ Private Protected 只有此程序的declared class和derived class， 不和别的程序玩
    We can access members inside the containing class or in a class that derives from a containing class, but only in the same assembly(project).
```
<h1>What is the extension method in C#? examples of built-in extension methods? How to create custom extension methods?</h1>
Extension methods enable you to "add" methods to exisiting types without creating a new derived type, recompling, or otherwise modifying the original class, struct or interface. Extension methods are static methods. 

```
static class NewMethodClass {
    // Method 4
    public static void M4(this Geek g)
    {
        Console.WriteLine("Method Name: M4");
    }
  
    // Method 5
    public static void M5(this Geek g, string str)
    {
        Console.WriteLine(str);
    }
}
  
// Now we create a new class in which
// Geek class access all the five methods
public class GFG {
  
    // Main Method
    public static void Main(string[] args)
    {
        Geek g = new Geek();
        g.M1();
        g.M2();
        g.M3();
        g.M4();
        g.M5("Method Name: M5");
    }
}
```

<h1>What does the underscore _ represent in a switch expression?</h1>
The underscore (_) character replaces the default keyword to signify that it should match anything if reached. The bodies are now expressions instead of statements. The selected body becomes the switch expression's result.

<h1>Sealed Class</h1>
A sealed class, in C#, is a class that cannot be inherited by any class but can be instantiated.


<h1>Ref vs. Out vs. Params</h1>
The ref keyword passes arguments by reference. It means any changes made to this argument in the method will be reflected in that variable when control returns to the calling method.

```
public static string GetNextName(ref int id)
{
    string returnText = "Next-" + id.ToString();
    id += 1;
    return returnText;
}
static void Main(string[] args)
{
    int i = 1;
    Console.WriteLine("Previous value of integer i:" + i.ToString());
    string test = GetNextName(ref i);
    Console.WriteLine("Current value of integer i:" + i.ToString());
}
```
The out keyword passes arguments by reference. This is very similar to the ref keyword.

```
public static string GetNextNameByOut(out int id)
{
    id = 1;
    string returnText = "Next-" + id.ToString();
    return returnText;
}
static void Main(string[] args)
{
    int i = 0;
    Console.WriteLine("Previous value of integer i:" + i.ToString());
    string test = GetNextNameByOut(out i);
    Console.WriteLine("Current value of integer i:" + i.ToString());
}
```

```diff
- Ref
used to state that the parameter passed @@ may @@ be modified by the method.
- In
used to state that the parameter passed @@ cannot  @@ be modified by the method.
- Out
used to state that the parameter @@ must @@ be modified by the method.

Both @@ Ref @@ and @@ In @@ the parameter has to have been initialized before passing in.
@@ Out @@ does not require this.
```

<h1> Pass by reference vs. Pass by Value </h1>
<h3>Pass by reference</h3>
The actual parameter passes to the function. 
<h3>Pass by Value</h3>
The parameter value copies to anther variable. Changes make inside the function are not reflected in the original value.

<h1>array vs. arrayList</h1>
Array is fixed-length data structure. dynamically-created object.
ArrayList is a variable-length data structure. a class of collections.

<h1>Example of encapsulation, where to implement</h1>
When we creating Entity, wrapping up of data under a signle unit.
Data hiding. Increased Flexibility
Reusability, Testing code is easier.

<h1>How do you handle exceptions? Syntax.</h1>
 error handling uses a try...[catch...][finally...] block, and errors are created via a throw statement

 <h1>what is generic, syntax to define </h1>
 Allows the user to define classes and methods with the placeholder. The basic idea behind using Generic is to allow type(Integer, String, ... or user-defined type) to be a parameter to methods, classes, and interface.

<h1>Dependency Injection</h1>
Injection of the service into the constructor of the class where it's used. The framework takes on the responsibility of creating an instance of the dependency and disposing of it when it's no longer needed.
<h3>Constructor Injection</h3>

Once we register a service, the IoC container automatically performs constructor injection if a service type is included as a parameter in a constructor. 
<h3>Action Method Injection</h3>
Sometimes we may only need dependency service type in a single action method. For this, use [FromServices] attribute with the service type parameter in the method.