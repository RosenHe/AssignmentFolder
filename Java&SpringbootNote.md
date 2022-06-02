```diff
+ Green
- Red
! Orange
@@ Pink @@
# Gray
```

Method References: enable us to define Lambda Expression by referring to methods directly using their name.

(important)Usage of Collections in coding: 
List, Set, Map - minimum ArrayList, LinkedList,HashMap(hashCode equals)
Sorting a List/Array in a given attribute. Like sort a list of students by age or name.

1. HashSet Class:

- Permits the null value.
- add(), remove(), contains(), size();
- HashSet does not store duplicate items. if you give 2 objects that are equal then it stores only the first one. hashcode() adn equals() method.
- Initial Capacity and load factor are the importance factor for iteration performance.
source:https://www.geeksforgeeks.org/hashset-in-java/

2. HashMap Class:

HashTable is synchronized, no null.
- HashMap is unsynchronized.
- HashMap allows null VALUES and only one null KEY. 
- get(), put(), getOrDefualt(), Hash_Map.remove(Object key)
- If duplicate: the old value will be replaced. No same key. 
source: https://www.geeksforgeeks.org/difference-between-hashmap-and-hashset/

3. ArrayList Class:

- dynamic length, store, access
- Initialized a default capacity of 10.

4. LinkedList Class:

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

(important)basic java coding: String, sub-class, constructor, getter/setter, etc.

5. String

6. Sub-class, Inheritance

7. Encapsulation
Encapsulation: make sure the "sensitive" data is hidden from user.
- 

(important)basic algorithm: Leetcode easy level

advanced concepts in java: OOP, SOLID, MVC, design patterns, multithreading.

basic network: HTTP, TCP

basic DB: SQL, joins, index..

JVM, JDK, JRE的区别

Springboot & Angular
Dependency Injection:


Create object -> know which objects needs these objects -> provide them objects (instead of having it construct them itself).
    - Help unit testing;
    - 

