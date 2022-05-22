1. What are the six combinations of access modifier keywords and what do they do? 

```diff
+ Public
    Accessible from everywhere in a project without any restrictions.
+ Private
    Accessible only inside a class or a structure.
+ Protected
    Accessible inside the class and in all classes that derive from the class.
+ Internal
    Limited exclusively to classes defined within the current project assembly
+ Protected Internal
    A combination of protected and internal.
    The proected internal member only in the same assembly or in a derived class in other assemblies.
+ Private Protected
    We can access members inside the containing class or in a class that derives from a containing class, but only in the same assembly(project).
```

![Access modifier keywords in C#](https://fatihbasol.com/wp-content/uploads/2021/09/access-modifiers.png)

2. What is the difference between the static, const, and readonly keywords when applied to
a type member?
```diff
+ Static
    The keyword whose value we can change during runtion or we can assign it at run time but only through the non-static constructor.
    - Cannot be instantiated.
! If multiple instances of a class are created, the last updated value of a static member will be available to all instances.
一个class有一个memberNumber field。 这个就可以弄成static。这样子每次create 一个class。 这个membernumber++。
+ Const
    A variable of which value is constant but at complier time.
    By default a const is static and we cannot change the value of a const variable throughout the entire program.
    @@Immutable value across the system.@@

+ Readonly
    The difference lies in @@ when @@ the value of the variable is known throughout the lifecycle of the application. For ReadOnly-> the latest value is know by the @@ runtion @@. For Const -> the value must be known by compile time.

    Const and Readonly both are immutable data types.
    The first difference is the timeslot which initializes the const or readonly variables. 
    The first, const, is initialized during @@ compile-time @@ and the latter, readonly, initialized is by the latest @@ run-time @@. 
    The second difference is that readonly can only be initialized at the class-level. 
    Another important difference is that const variables can be referenced through "ClassName.VariableName", while readonly can be referenced through "InstanceName.VariableName".
```
3. What does a constructor do?
```
    Initializes a new created object of that type(class).
```
4. Why is the partial keyword useful?
```
- With the help of partial classes, multiple developers can work simultaneously in the same class in different files.
- With the help of a partial class concept, you can split the UI of the design code and the business logic code to read and understand the code.
- When you were working with automatically generated code, the code can be added to the class without having to recreate the source file like in Visual studio.
- You can also maintain your application in an efficient manner by compressing large classes into small ones.
```
5. What is a tuple?
```diff
    A data structure which consists of the multiple parts.
! Benefic:
    - With Tuples, there is no need to create any separate data structure. In this case, you can use Tuple<T1,T2, T3..T8>.
    - Array, List only store for a specific type. But Tuples are able to store max(8) numbers. can be any type.

```
6. What does the C# record keyword do?
```diff
    To define a @@ reference @@ type that provides built-in functionality for encapsulationg data.
```
7. What does overloading and overriding mean?
```
overloading: Same function name, different parameter
overriding: Rewrite parent's function. 
Overloading occurs when two or more methods in one class have the same method name but different parameters. Overriding occurs when two methods have the same method name and parameters. One of the methods is in the parent class, and the other is in the child class.
```
8. What is the difference between a field and a property?
```diff
+ Field：
    A variable of any type that is declared directly in the class.
    - KEEP private to a class and accessed via getter and setter.
+ Property:
    a member that provides a flexible mechanism to read, write or compute the value of a private field. 
    - provide a level of abstraction allowing you to change the fields while not affecting the external way they are accessed by the things that use your class.
```

9. How do you make a method parameter optional?
```
1. By using default value.
2. By using method overloading.
3. By using Optinal Arrtribute.
```
10. What is an interface and how is it different from abstract class?
```
An abstract class allows you to create functionality that subclasses can implement or override.
An interface only allows you to define functionality, not implement it.
Whereas a class can extend only one abstract class, it can take advantage of multiple interfaces.

```
11. What accessibility level are members of an interface?
```
Interfaces declared directly within a namespace can be public or internal.
Interface members are public by default because the purpose of an interface is to enable other types to access a class or struct. 
- Interface member declarations may include any access modifier. This is most useful for static methods to provide common implementations needed by all implementors of a class.
```
12. True/False. Polymorphism allows derived classes to provide different implementations
of the same method.
<span style="color:#911a00">True</span>

13. True/False. The override keyword is used to indicate that a method in a derived class is
providing its own implementation of a method.
<span style="color:#911a00">True</span>

14. True/False. The new keyword is used to indicate that a method in a derived class is
providing its own implementation of a method.
<span style="color:#911a00">False</span>

15. True/False. Abstract methods can be used in a normal (non-abstract) class. 
<span style="color:#911a00">True</span>

16. True/False. Normal (non-abstract) methods can be used in an abstract class. 
<span style="color:#911a00">True</span>

17. True/False.
Derived classes can override methods that were virtual in the base class. 
<span style="color:#911a00">True</span>

18. True/False.
Derived classes can override methods that were abstract in the base class. 
<span style="color:#911a00">True</span>

19. True/False.
In a derived class, you can override a method that was neither virtual non abstract in the
base class.
<span style="color:#911a00">False????</span>

20. True/False. A class that implements an interface does not have to provide an
implementation for all of the members of the interface.
<span style="color:#911a00">False</span>

21. True/False. A class that implements an interface is allowed to have other members that
aren’t defined in the interface.
<span style="color:#911a00">True</span>

22. True/False. A class can have more than one base class.
<span style="color:#911a00">False</span>

23. True/False. A class can implement more than one interface.
<span style="color:#911a00">True</span>

<h2>Working With Methods</h2>

1. Generate Number, Reverse and Print
```
public class Class1
    {
        public static int[] GenerateNumbers()
        {
            int[] numbers = new int[] {1 ,2 ,3 ,4 ,5 , 6, 7 ,8, 9 ,10};
            return numbers;
        }
        public static void Reverse(int[] input)
        {
            int n = input.Length;
            int left;
            int right;
            if(n % 2 == 0)
            {
                left = n/2-1;
                right = n/2;
                while(left >=  0 && right < n)
                {
                    int temp = input[left];
                    input[left--] = input[right];
                    input[right++] = temp;
                }
            }
            else
            {
                left = n / 2 - 1;
                right = n / 2 + 1;
                while (left >= 0 && right < n)
                {
                    int temp = input[left];
                    input[left--] = input[right];
                    input[right++] = temp;
                }
            }

        }
        public static void PrintNumber(int[] input)
        {
            foreach(int n in input)
            {
                Console.Write(n + " ");
            }
        }
    }
```

2. Fibonacci
```
        public static void Fibonacci(int n) 
        {
            int[] memo = new int[n+1];
            int res = helper(memo, n);
            Console.WriteLine(res);
        }
        public static int helper(int[] memo, int n)
        {
            if (n == 0 || n == 1) return n;
            if(memo[n] != 0) return memo[n];
            memo[n] = helper(memo, n-1) + helper(memo, n-2);
            return memo[n];
        }
```

<h2>Designing and Building Classes using object-oriented principles </h2>
Shown on Day3 folder.