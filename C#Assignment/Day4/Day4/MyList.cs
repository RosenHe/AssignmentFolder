using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
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
}
