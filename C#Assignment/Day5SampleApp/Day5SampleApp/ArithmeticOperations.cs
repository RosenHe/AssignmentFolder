using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5SampleApp
{
    public class ArithmeticOperations
    {
        public void Addition(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Subtraction(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public int Multiply(int a, int b) // this doesn't work due to the return type/
        {
            return a * b;
        }
        public void Division(float a, float b)//this doesn't work because the parameter
        {
            Console.WriteLine(a/b);
        }
        public void UseDelegate(MathDelegate del, int a, int b)
        {
            del(a, b);
        }
    }
}
