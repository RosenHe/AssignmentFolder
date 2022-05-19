using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
