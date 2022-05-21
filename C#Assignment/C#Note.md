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
MathDelegate mathDelegate = delegate(int a, int b){
    return a+b;
};
```
<h4>Lamda Operation</h4>
Lamda operation is used to create an anonymous method, It uses delegate to create an anonymouse methods. 
```
MathDelegate mathDelegate = (a, b) => a * b;
```
<h5>Advantage</h5>
Enhanced Iterative Syntax.
Simplified variable scope.
When doing Leetcode. Sometime we use lamda express to make a maxium queue.

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
Predicate is a spoecial kind of Func, It represents a method that contains a set of criteria mostly defined inside an if condition and checks whether the passed parameter meets those criteria or not.
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
1. You can split the The UI od the design code and the business logic code to read and understand the code. 
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

```
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
overloading: @@Same function name, different parameter@@
overriding: @@Rewrite parent's function. @@
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

<h1>Tuple</h1>
Tuple, maximum 8, can store any type. < T1,T2, T3..T8 >

<h1>Record</h1>
Sometimes we have a class defined. but we need to update(add) new property. we have to modify the class, reassign and update. 
By using "With" expression, we can define new values for a specific property.

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
Creating obejct of the Class that it is by initializing all the instance variables and creating a place in memory to hold the object. no overridden or overloaded.

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
<h1> </h1>
<h1> </h1>
<h1> </h1>
<h1> </h1>
