1. Describe the problem generics address.
```diff
To address the type safety issue, the .NET framework provides generics to create classes, structures, interfaces, and methods that have placeholders for the types they use. @@ Generics are commonly used to create type-safe collections for both reference and value types. @@
```
2. How would you create a list of strings, using the generic List class?
```diff
List<string> a = new List<string>();
```
3. How many generic type parameters does the Dictionary class have?
```
2, one for key, one for value.
```
4. True/False. When a generic class has multiple type parameters, they must all match.
```
True. It’s possible (though not with your method signature) and yes, with your signature the types must be the same. (source: https://www.rampfesthudson.com/can-a-generic-class-have-multiple-generic-parameters/)
```
5. What method is used to add items to a List object?
```
add(item): add item to the end of the list.
insert(index, item): inserts an item at a given position.
InsertRange(index, items): add items at the given position. 

```
6. Name two methods that cause items to be removed from a List.
```
RemoveAt(index): remove the item at the specified index.
Remove(item): remove the first occurrence of the item.
RemoveAll(): clear list.
```
7. How do you indicate that a class has a generic type parameter?
```
specifying a type parameter in an angle brackets after a type name. <T>

```
8. True/False. Generic classes can only have one generic type parameter.
```
F
```
9. True/False. Generic type constraints limit what can be used for the generic type.
```
T. The type argument must be non-nullable value types such as primitive data types int, char, bool, float, etc.
```
10. True/False. Constraints let you use the methods of the thing you are constraining to.
```
True
```

<h2> Mystack </h2>

```
namespace Day4
{
    public class MyStack<T> 
    {
        private List<T> List { get { return List; } }
        private int num = 0;

        public int Count()
        {
            return num;
        }

        public T Pop()
        {
            if(num == 0)
            {
                throw new IndexOutOfRangeException("My Stack's length is 0, can't Pop().");

            }
            T temp = List[List.Count - 1];
            List.RemoveAt(List.Count - 1);
            num--;
            return temp;
        }

        public void Push(T val)
        {
            List.Add(val);
            num++;
        }
    }
}
```

<h2> MyList </h2>

```
    internal class MyList<T>
    {
        class Node
        {
            public T val;
            public Node next;
            public Node(T val)
            {
                this.val = val;
            }
            public Node()
            {

            }
        }

        private Node head;
        private int size;
        public void Add(T element)
        {
            if(head == null)
            {
                head = new Node(element);
            }
            else
            {
                Node dummy = head;
                while(dummy.next != null)
                {
                    dummy = dummy.next;
                }
                dummy.next = new Node(element);
            }
            size++;
        }
        public T removeAtIndex(int index)
        {
            if (index < 0 || index >= size) throw new IndexOutOfRangeException("Index is out of Range. At index:" + index);
            size--;
            T temp = head.val;
            if (index == 0)
            {
                temp = head.val;
                head = head.next;
            }
            else
            {
                Node dummy = head;
                for (int i = 0; i < index - 1; i++)
                {
                    dummy = dummy.next;
                    temp = dummy.next.val;
                }
                dummy.next = dummy.next.next;
            }
            return temp;
        }
        public bool contains(T element)
        {
            Node dummy = head;
            for(int i = 0; i < size; i++)
            {
                if (dummy.val.Equals(element)) return true;
                dummy = dummy.next;
            }
            return false;
        }
        public void clear()
        {
            head = null;
            size = 0;
        }
        public void insertAt(T element, int index) 
        {
            if(index > size) throw new IndexOutOfRangeException("Index is greater than current size.");
            Node dummy = head;
            if(index == 0)
            {
                head = new Node(element);
                head.next = dummy;
            }
            else if(index == size)
            {
                while(dummy.next != null)
                {
                    dummy = dummy.next;
                }
                dummy.next = new Node(element);
            }
            else
            {
                for(int i = 0; i < index - 1; i++)
                {
                    dummy = dummy.next;
                }
                Node node = new Node(element);
                node.next = dummy.next;
                dummy.next = node;
            }
            size++;
        }
        public void deleteAt(int index)
        {
            if(index >= size) throw new IndexOutOfRangeException("Delete index is greater or equal to size.");
            if (index == 0)
            {
                head = head.next;
                return;
            }
            Node dummy = head;
            for(int i = 0; i < index - 1; i++)
            {
                dummy = dummy.next;
            }
            dummy.next = dummy.next.next;

        }
        public T findAtIndex(int index)
        {
            if (index >= size || index < 0)
                throw new IndexOutOfRangeException("Find index can only in range 0 to " + size);
            Node dummy = head;
            for(int i = 0; i < index; i++)
            {
                dummy = dummy.next;
            }
            return dummy.val;
        }
    }

```

<h2>GenericRepository</h2>
Showns on C# files.
Generic.cs ->Entity
GenericRepository.cs ->Repository class
IRepository.cs ->Repository interface.
