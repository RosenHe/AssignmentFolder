```diff
+ Green
- Red
! Orange
@@ Pink @@
# Gray
```

Method References: enable us to define Lambda Expression by referring to methods directly using their name.
<h1>Collections</h1>
<h4> HashSet Class:</h4>

- Permits the null value.
- add(), remove(), contains(), size();
- HashSet does not store duplicate items. if you give 2 objects that are equal then it stores only the first one. hashcode() adn equals() method.
- Initial Capacity and load factor are the importance factor for iteration performance.
source:https://www.geeksforgeeks.org/hashset-in-java/

<h4>HashMap Class:</h4>

HashTable is synchronized, no null.
- HashMap is unsynchronized.
- HashMap allows null VALUES and only one null KEY. 
- get(), put(), getOrDefualt(), Hash_Map.remove(Object key)
- If duplicate: the old value will be replaced. No same key. 
source: https://www.geeksforgeeks.org/difference-between-hashmap-and-hashset/

<h4> ArrayList Class:</h4>

- dynamic length, store, access
- Initialized a default capacity of 10.

<h4> LinkedList Class:</h4>

- double linked list， better for manipulating data. 
- act as a list and queue.

```
class Sortbyroll implements Comparator<T>{
    public int compare(Student a, Student b){
        return a.rollno - b. rollno;
    }
}
class Main{
    public static void main(String[] args){
        Collections.sort(array, new Sortbyroll());  
    }
}
--------------------------------------------------------------
//PrioprityQueue: mini Queue;
PriorityQueue<ListNode> pq = new PrioprityQueue<>((a, b) ->
    (a.val - b.val));//升序

PriorityQueue<int[]> maxpq = new PriorityQueue<>(
    (int[] pair1, int[] pair2) -> { 
            return pair2[1] - pair1[1];
            }//降序
);
```
<h1>String</h1>

- Immutable
- Frequency modify use StringBuilder
- StringBuffer and StringBuilder are similar, but StringBuilder is faster and preferred over StringBuffer for the single-threaded program. If thread safety is needed, then StringBuffer is used.
    

<h1>Inheritance</h1>

- Overloading: Same name diff parameter
- Overriding same name, rewrite function.

<h1>Encapsulation</h1>
Encapsulation: make sure the "sensitive" data is hidden from user.
    
- Data hiding: hiding unwanted info. such as restricting access to any member of an object.
- Data binding: binding data members and the method together.

<h1>Abstraction & Interface</h1>
Some related class that need to share some lines of code, then we put these line of code within the abstract class, then this abstract class should be exteneded by all these related class.
Interface just specific the behavior of a particular datatype, but not concered about the implementation of its behavior.

<h1>OOP</h1>
OOP means that organizes software design around data, or objects, rather than functions and logic.

<h1>SOLID</h1>
<h4>Single-Responsiblity Principle</h4>
class should have only one job.
<h4>Open-closed Principle</h4>Objects or entity should be open for extension but closed for modification
<h4>Liskov Substitution Principle </h4> every subclass or derived class should be subsitutable for their base or parent class. -----Simply put, if class A is a subtype of class B, we should be able to replace B with A without disrupting the behavior of our program.
<h4>Interface Segregation Principle </h4>  define interface functions, shouldn't be forced to depend on methods they do not use.
<h4>Dependency Inversion Principle</h4>Entities must depend on abstraction, not on concretions. high-level module must not depend on the low-level module, but they should depend on abstraction. 

<h1>MVC</h1>

<h1>Design patterns</h1>

<h1>Multithreading</h1>

<h1>HTTP</h1>

<h1>TCP</h1>

<h1>SQL Questions:</h1>
<h1>joins</h1>
left Join: return all data from left table and matching data from right table, if there is no matching will having null value.

<h1>index</h1>
Indexes are used to retrieve data from the database more quickly than otherwise.

<h1>JVM, JDK, JRE</h1>
<h4>JVM</h4>
Java Virtual Machine: whatever java program you run using JRE or JDK goes into JVM and JVM is responsible for executing the java program line by line, hence konwn as Interpreter.
<h4>JDK</h4>
Java Development kit: a kit provides the envioronment to develop and execute the java program.
<h4>JRE</h4>
Java Runtion Enviorment: an installation package that provides an enviorment to only run(not develope) the java program onto your machine. JRE is used by those who only want to run Java program that are End-Users of your system.



Springboot & Angular
<h1>Dependency Injection:</h1>
Create object -> know which objects needs these objects -> provide them objects (instead of having it construct them itself).
    - Help unit testing;
    - 

