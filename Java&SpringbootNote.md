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

<h4>hashCode()</h4>
return the hash code number of the collection.

<h4> ArrayList Class:</h4>

- dynamic length, store, access
- Initialized a default capacity of 10.

<h4> LinkedList Class:</h4>

- double linked list， better for manipulating data. 
- act as a list and queue.

<h4> PriorityQueue:</h4>

- O(log(n)) for add() and poll()
- not thread-safe
- based on priority heap (mini heap)

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
Class -> Object -> Method and method passing -> Abstraction/Encapsulation/Inheritance/Polymorphism.

<h1>SOLID</h1>
<h4>Single-Responsiblity Principle(Object Entity)</h4>
class should have only one job.
<h4>Open-closed Principle</h4>
Objects or entity should be open for extension but closed for modification
<h4>Liskov Substitution Principle(Extends)</h4> 
every subclass or derived class should be subsitutable for their base or parent class. -----Simply put, if class A is a subtype of class B, we should be able to replace B with A without disrupting the behavior of our program.
<h4>Interface Segregation Principle(Interface Inheritance)</h4>  
define interface functions, shouldn't be forced to depend on methods they do not use.
<h4>Dependency Inversion Principle</h4>
Entities must depend on abstraction, not on concretions. high-level module must not depend on the low-level module, but they should depend on abstraction. 

<h1>MVC</h1>
MVC (Model-View-Controller) is a pattern in software design commonly used to implement user interfaces, data, and controlling logic. It emphasizes a separation between the software's business logic and display.
<h1>Design patterns</h1>

<h1>Multithreading</h1>
<h5>Process</h5>
A process is the execution of a program. It includes the program itself, data, resources such as files, and execution info such as process relation information kept by the OS. The OS allows users to create, schedule, and terminate the processes via system calls.
<h5>Thread</h5>
A thread is a semi-process. It has its own stack and executes a given piece of code. Unlike a real process, the thread normally shares its memory with other threads. Conversely, processes usually have a different memory area for each one of them.

<h4>Multi-threading</h4>
- A process of executing multiple threads simultaneously.
- Thread-based multitasking is a lightweight process and occupies different address spaces in memory.
- Advantage: they don't allocate separate memory area so saves memory, and contect-switching between the threads takes less time than process.

<h4>Multi-processing</h4>
Process-based multitasking is a heavyweight process and occupies different address spaces in memory.

<h4>Synchronization</h4>
- Synchronization is the capability to control the access of multiple threads to any shared resource. Where we want to allow one thread to access the shared resource.
- To prevent thread interference.
- To prevent consistency problem.
- 
<h4>Deadlock</h4>
Deadlock occur in a situation when a thread is waiting for an object lock, that is acquired by another thread and second thread is waiting for an object lock that is acquired by first thread. Both thread are waiting for each other to release the lock.

<h1>HTTP</h1>
- HTTP Requests are message which are sent by the client or user to initiate an action on the server.

<h1>TCP</h1>
Transmission Control Protocal provides reliable communication between the sender and receiver. TCP is used along with the Internet Protocal referred as TCP/IP.

<h1>UDP</h1>
User Datagram Protocal provides a connection-less protocol service allowing packet of data to be transferred along two or more nodes.
  
<h1>Socket</h1>
An endpoint between 2 ways communications.
- Java Socket Programming is used for communication between the applications running on different JRE.
- can be conncection-oriented or connection-less.

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

